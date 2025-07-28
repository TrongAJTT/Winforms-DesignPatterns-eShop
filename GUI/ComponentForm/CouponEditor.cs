using _3S_eShop.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.Validate;
using _3S_eShop.PatternDistinctive.Strategy;
using _3S_eShop.PatternDistinctive.Strategy.CharacterValidator;
using _3S_eShop.BLL.DTOs;
using _3S_eShop.CustomComponents;
using _3S_eShop.Utilities;

namespace _3S_eShop.GUI.ComponentForm
{
    public partial class CouponEditor: Form
    {
        private CouponBLL couponBLL;
        private CouponDTO couponDTO;
        private long id;

        // không truyền id của coupon thì mặc định là thêm mới
        public CouponEditor(long id = -1)
        {
            InitializeComponent();
            initValidator();

            tbDiscountPercent.InputCharacterValidator = new NumberOnlyCharacterStrategy();
            tbMaxDiscountAmount.InputCharacterValidator = new NumberOnlyCharacterStrategy();
            tbRemainingUses.InputCharacterValidator = new NumberOnlyCharacterStrategy();

            couponBLL = new CouponBLL(new DAL.DAOs.CouponDAO());
            this.id = id;
            lbErr.Visible = false;

            // lấy dữ liệu coupon từ database
            if (id != -1)
            {
                couponDTO = couponBLL.GetCoupon(id.ToString());
                tbDiscountPercent.Texts = couponDTO.DiscountPercent.ToString();
                tbMaxDiscountAmount.Texts = couponDTO.MaxDiscountAmount.ToString();
                tbRemainingUses.Texts = couponDTO.RemainingUses.ToString();
                datePickerStartDate.Value = couponDTO.StartDate;
                datePickerExpirationDate.Value = couponDTO.ExpirationDate;
            }
            else
            {
                datePickerStartDate.Value = DateTime.Now;
                datePickerExpirationDate.Value = DateTime.Now.AddDays(30); // mặc định là 30 ngày
            }
        }

        private void initValidator()
        {
            tbDiscountPercent.Valid = new DiscountPercentValidator();
            tbMaxDiscountAmount.Valid = new MaxDiscountAmountValidator();
            tbRemainingUses.Valid = new MaxDiscountAmountValidator();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = false;

            // validate dữ liệu
            if (ValidateTemplate(tbDiscountPercent, lbErr) == false) return;
            if (ValidateTemplate(tbMaxDiscountAmount, lbErr) == false) return;
            if (ValidateTemplate(tbRemainingUses, lbErr) == false) return;
            bool isMatchStartDate = datePickerStartDate.Value < datePickerExpirationDate.Value;
            DisplayError(lbErr, "Ngày bắt đầu phải trước ngày hết hạn", isMatchStartDate);
            if (!isMatchStartDate) return;
            bool isMatchEndDate = datePickerExpirationDate.Value > DateTime.Now;
            DisplayError(lbErr, "Ngày hết hạn phải sau ngày hiện tại", isMatchEndDate);
            if (!isMatchEndDate) return;

            // lưu dữ liệu vào database
            if (id == -1)
            {
                success = couponBLL.Add(
                    byte.Parse(tbDiscountPercent.Texts),
                    uint.Parse(tbMaxDiscountAmount.Texts),
                    datePickerStartDate.Value,
                    datePickerExpirationDate.Value,
                    byte.Parse(tbRemainingUses.Texts)
                );
            }
            else
            {
                success = couponBLL.Update(
                    id,
                    byte.Parse(tbDiscountPercent.Texts),
                    uint.Parse(tbMaxDiscountAmount.Texts),
                    datePickerStartDate.Value,
                    datePickerExpirationDate.Value,
                    byte.Parse(tbRemainingUses.Texts)
                );
            }

            if (success)
            {
                MySystem.ShowToastMessageAtTopRight("Lưu mã giảm giá thành công");
                this.DialogResult = DialogResult.OK;
                if (id != -1)
                {
                    this.Close();
                }
                else
                {
                    tbDiscountPercent.Texts = "";
                    tbMaxDiscountAmount.Texts = "";
                    tbRemainingUses.Texts = "";
                    datePickerStartDate.Value = DateTime.Now;
                    datePickerExpirationDate.Value = DateTime.Now.AddDays(30);
                }
            }
            else
            {
               MySystem.ShowToastMessageAtTopRight("Lưu không thành công", CustomControls.ToastBox.enmType.Error);
            }
        }


        private bool ValidateTemplate(AdvancedTextBox textBox, System.Windows.Forms.Label errLabel, string param = null)
        {
            bool valid = textBox.IsValid(param);
            DisplayError(errLabel, textBox.GetInvalidMessage(), valid);
            return valid;
        }

        private void DisplayError(System.Windows.Forms.Label errLabel, string errorMessage, bool isValid)
        {
            if (isValid)
            {
                errLabel.Visible = false;
            }
            else
            {
                errLabel.Text = errorMessage;
                errLabel.Visible = true;
            }
        }
    }
}
