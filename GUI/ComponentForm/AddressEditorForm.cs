using _3S_eShop.BLL;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.BLL.DTOs.ViewModel;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.PatternDistinctive.Strategy.CharacterValidator;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class AddressEditorForm: Form
    {
        private const string DataUrl = "https://raw.githubusercontent.com/kenzouno1/DiaGioiHanhChinhVN/master/data.json";
        private List<City> _allCitiesData; // Lưu trữ toàn bộ dữ liệu
        private static readonly HttpClient client = new HttpClient(); 
        // Nên dùng static HttpClient

        // --- Placeholder items ---
        // Sử dụng đối tượng cụ thể làm placeholder sẽ tốt hơn là string đơn thuần
        // khi dùng DataSource, DisplayMember, ValueMember
        private readonly City _placeholderCity = new City 
            { Id = "", Name = "Chọn tỉnh thành" };
        private readonly District _placeholderDistrict = new District 
            { Id = "", Name = "Chọn quận huyện" };
        private readonly Ward _placeholderWard = new Ward 
            { Id = "", Name = "Chọn phường xã" };
        
        private UserAddressDTO _address;
        private bool isComplete = false;

        /// <summary>
        /// Trả về trạng thái xử lý của Form
        /// </summary>
        public bool IsComplete { get => isComplete; }

        public AddressEditorForm()
        {
            InitializeComponent();
            // Thiết lập xử lý dữ liệu
            txtName.Valid = new TextLengthConstraintValidator(100, 6);
            txtPhone.Valid = new TextLengthConstraintValidator(15,10);
            txtPhone.InputCharacterValidator = new NumberOnlyCharacterStrategy();
            txtAddress.Valid = new TextLengthConstraintValidator(100, 10);
            // Ẩn các label lỗi ban đầu
            lblErrName.Text = errPhone.Text = errAddress.Text = errAdminArea.Text = "";
            // Dữ liệu mặc định
            _address = new UserAddressBuilder().Default().Build();
        }

        public AddressEditorForm(UserAddressDTO addressToEdit) : this()
        {
            _address = addressToEdit;
            // Nếu có dữ liệu thì hiển thị lên form
            if (addressToEdit != null)
            {
                // Gán dữ liệu vào các TextBox
                txtName.Texts = addressToEdit.RecipientName;
                txtPhone.Texts = addressToEdit.RecipientPhone;
                toggleDefault.Checked = addressToEdit.IsDefault;
                txtAddress.Texts = addressToEdit.StreetAddress;
            }
        }

        private async void AddressEditorForm_Load(object sender, EventArgs e)
        {
            // Thiết lập ban đầu cho ComboBoxes
            SetupComboBoxes();

            // Tải dữ liệu bất đồng bộ
            await LoadAddressDataAsync();

            // Kích hoạt ComboBox tỉnh/thành nếu tải thành công
            if (_allCitiesData != null && _allCitiesData.Any())
            {
                PopulateCityComboBox();
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu địa chỉ. Vui lòng kiểm tra kết nối mạng hoặc thử lại sau.", "Lỗi Tải Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể vô hiệu hóa các ComboBox nếu muốn
                cboCity.Enabled = false;
            }

            // Nếu có địa chỉ để chỉnh sửa, tự động chọn tỉnh/thành, quận/huyện, phường/xã
            if (_address != null)
            {
                // Tách địa chỉ hành chính thành các phần
                string[] parts = _address.AdministrativeArea.Split(',');
                string cityName = parts[0].Trim();
                string districtName = parts.Length > 1 ? parts[1].Trim() : "";
                string wardName = parts.Length > 2 ? parts[2].Trim() : "";

                // Tìm và chọn tỉnh/thành, quận/huyện, phường/xã tương ứng
                var city = _allCitiesData?.FirstOrDefault(c => c.Name == cityName);
                if (city != null)
                {
                    cboCity.SelectedItem = city;
                    PopulateDistrictComboBox(city);
                    var district = city.Districts?.FirstOrDefault(d => d.Name == districtName);
                    if (district != null)
                    {
                        cboDistrict.SelectedItem = district;
                        PopulateWardComboBox(district);
                        var ward = district.Wards?.FirstOrDefault(w => w.Name == wardName);
                        if (ward != null)
                        {
                            cboWard.SelectedItem = ward;
                        }
                    }
                }
            }
            
        }

        #region Address Combobox Region

        private void SetupComboBoxes()
        {
            // Cấu hình City ComboBox
            cboCity.DisplayMember = "Name"; // Hiển thị thuộc tính Name
            cboCity.ValueMember = "Id";     // Giá trị là thuộc tính Id (tùy chọn)
            cboCity.DataSource = new List<City> { _placeholderCity }; // Bắt đầu với placeholder
            cboCity.SelectedIndex = 0;

            // Cấu hình District ComboBox
            cboDistrict.DisplayMember = "Name";
            cboDistrict.ValueMember = "Id";
            cboDistrict.DataSource = new List<District> { _placeholderDistrict };
            cboDistrict.SelectedIndex = 0;
            cboDistrict.Enabled = false; // Vô hiệu hóa ban đầu

            // Cấu hình Ward ComboBox
            cboWard.DisplayMember = "Name";
            cboWard.ValueMember = "Id";
            cboWard.DataSource = new List<Ward> { _placeholderWard };
            cboWard.SelectedIndex = 0;
            cboWard.Enabled = false; // Vô hiệu hóa ban đầu

            // Gắn sự kiện SelectedIndexChanged
            cboCity.OnSelectedIndexChanged += cboCity_SelectedIndexChanged;
            cboDistrict.OnSelectedIndexChanged += cboDistrict_SelectedIndexChanged;
            // cboWard.SelectedIndexChanged += cboWard_SelectedIndexChanged; // Nếu cần xử lý khi chọn phường/xã
        }

        // --- Data Loading ---
        private async Task LoadAddressDataAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(DataUrl);
                response.EnsureSuccessStatusCode(); // Ném exception nếu request không thành công (status code != 2xx)
                string jsonString = await response.Content.ReadAsStringAsync();

                // Phân tích JSON thành danh sách các đối tượng City
                _allCitiesData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<City>>(jsonString);
                
            }
            catch (HttpRequestException httpEx)
            {
                // Log lỗi hoặc hiển thị thông báo thân thiện hơn
                Console.WriteLine($"Lỗi HTTP khi tải dữ liệu: {httpEx.Message}");
                _allCitiesData = null; // Đảm bảo dữ liệu là null nếu có lỗi
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"Lỗi phân tích JSON: {jsonEx.Message}");
                _allCitiesData = null;
            }
            catch (Exception ex) // Bắt các lỗi khác
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
                _allCitiesData = null;
            }
        }

        // --- Populate ComboBoxes ---
        private void PopulateCityComboBox()
        {
            if (_allCitiesData == null) return;

            var citiesToShow = new List<City> { _placeholderCity }; // Bắt đầu list mới với placeholder
            citiesToShow.AddRange(_allCitiesData.OrderBy(c => c.Name)); // Thêm dữ liệu đã tải và sắp xếp

            cboCity.DataSource = citiesToShow; // Gán DataSource
            cboCity.SelectedIndex = 0;       // Chọn placeholder
            cboCity.Enabled = true;          // Kích hoạt ComboBox
        }

        private void PopulateDistrictComboBox(City selectedCity)
        {
            var districtsToShow = new List<District> { _placeholderDistrict }; // Placeholder
            if (selectedCity != null && selectedCity.Districts != null)
            {
                districtsToShow.AddRange(selectedCity.Districts.OrderBy(d => d.Name));
            }

            cboDistrict.DataSource = districtsToShow;
            cboDistrict.SelectedIndex = 0;
            cboDistrict.Enabled = districtsToShow.Count > 1; 
            // Chỉ kích hoạt nếu có quận/huyện (ngoài placeholder)
        }

        private void PopulateWardComboBox(District selectedDistrict)
        {
            var wardsToShow = new List<Ward> { _placeholderWard }; // Placeholder
            if (selectedDistrict != null && selectedDistrict.Wards != null)
            {
                wardsToShow.AddRange(selectedDistrict.Wards.OrderBy(w => w.Name));
            }

            cboWard.DataSource = wardsToShow;
            cboWard.SelectedIndex = 0;
            cboWard.Enabled = wardsToShow.Count > 1; // Chỉ kích hoạt nếu có phường/xã
        }

        // --- Event Handlers ---
        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy đối tượng City đang được chọn
            City selectedCity = cboCity.SelectedItem as City;

            // Reset và vô hiệu hóa các combobox con
            PopulateDistrictComboBox(null); // Reset District
            PopulateWardComboBox(null);     // Reset Ward

            // Nếu lựa chọn hợp lệ (không phải placeholder) thì tải District
            if (selectedCity != null && !string.IsNullOrEmpty(selectedCity.Id))
            {
                PopulateDistrictComboBox(selectedCity);
            }
        }

        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy đối tượng District đang được chọn
            District selectedDistrict = cboDistrict.SelectedItem as District;

            // Reset và vô hiệu hóa combobox con
            PopulateWardComboBox(null); // Reset Ward

            // Nếu lựa chọn hợp lệ (không phải placeholder) thì tải Ward
            if (selectedDistrict != null && !string.IsNullOrEmpty(selectedDistrict.Id))
            {
                PopulateWardComboBox(selectedDistrict);
            }
        }

        #endregion

        private void UpdateValue()
        {
            _address.UserId = MainForm.User.Id;
            _address.IsDefault = toggleDefault.Checked;
            _address.RecipientName = txtName.Texts;
            _address.RecipientPhone = txtPhone.Texts;
            _address.AdministrativeArea = $"{cboCity.Texts}, {cboDistrict.Texts}, {cboWard.Texts}";
            _address.StreetAddress = txtAddress.Texts;
        }

        private bool CheckValidate()
        {
            bool result = true;

            // Họ tên người nhận
            result = result && MySystem.ValidateTemplate(txtName, lblErrName);

            // Số điện thoại
            result = result && MySystem.ValidateTemplate(txtPhone, errPhone);

            // Địa chỉ hành chính
            if (cboCity.SelectedIndex == 0)
            {
                errAdminArea.Text = "Vui lòng chọn tỉnh thành";
                result = false;
            }
            else if (cboDistrict.SelectedIndex == 0)
            {
                errAdminArea.Text = "Vui lòng chọn quận/huyện";
                result = false;
            }
            else if (cboWard.SelectedIndex == 0)
            {
                errAdminArea.Text = "Vui lòng chọn phường/xã";
                result = false;
            }
            else
            {
                errAdminArea.Text = "";
            }

            // Địa chỉ cụ thể
            result = result && MySystem.ValidateTemplate(txtAddress, errAddress);

            return result;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidate()) return;

            // Cập nhật giá trị địa chỉ
            UpdateValue();

            // Hiện biểu tượng tải trong khi lưu
            loadingControl.Visible = true;

            // Ngăn không cho người dùng thoát Form
            this.ControlBox = false;

            await Task.Run(() =>
            {
                var dao = new UserAddressDAO();
                var bll = new UserAddressBLL(dao);
                // Nếu địa chỉ chưa tồn tại (Id = -1), thêm mới
                if (_address.Id == -1)
                {
                    _address = bll.AddAddressForUser(_address.UserId, _address);
                }
                // Cập nhật địa chỉ
                else
                {
                    _address = dao.Update(_address.Id, _address);
                }

                // Cập nhật các địa chỉ khác thành không mặc định nếu địa chỉ này là mặc định
                bll.SetDefaultAddressFor(_address.Id);
            });

            // Hiện thông báo
            loadingControl.Visible = false;
            MySystem.ShowToastMessageAtTopRight("Cập nhật địa chỉ thành công");

            // Đánh dấu hoàn tất và thoát form
            isComplete = true;
            this.Close();
        }
    }
}
