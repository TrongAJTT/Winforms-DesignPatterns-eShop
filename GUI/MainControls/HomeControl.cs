using _3S_eShop.BLL;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.DAL.Database;
using _3S_eShop.GUI.ComponentControls;
using _3S_eShop.GUI.Test;
using _3S_eShop.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _3S_eShop.GUI.MainControls
{
    public partial class HomeControl : UserControl
    {
        // Đây là control đầu tiên hiện lên nên không cần thiết lập lazy load

        // Hàm khởi tạo
        public HomeControl()
        {
            InitializeComponent();
            InitializeUI();
            LoadData();
        }

        // Thiết lập giao diện
        private void InitializeUI()
        {
            flowSubBanner.AutoSize = true;
        }

        // Tải dữ liệu
        private void LoadData()
        {
            mainBanner.LoadData();
            SetUpSubBanner();
            SetUpSaleProduct();
            SetUpNewProduct();
            SetUpRecentProduct();
        }

        // Thiết lập banner phụ
        private void SetUpSubBanner()
        {
            flowSubBanner.AutoSize = true;
            flowSubBanner.BackColor = Color.Transparent;
            //Task.Run(() =>
            //{
                var subBanners = RedisHandler.GetAllBanner(false);
                if (subBanners.Count > 0)
                {
                    foreach (var banner in subBanners)
                    {
                        var subBannerControl = new BannerSubControl(banner);
                        flowSubBanner.SafeInvoke(() => flowSubBanner.Controls.Add(subBannerControl));
                    }
                }
                else
                {
                    flowSubBanner.SafeInvoke(() => flowSubBanner.Dispose());
                }
            //});
        }

        // Thiết lập sản phẩm giảm giá
        private void SetUpSaleProduct()
        {
            var list = new ProductVariantBLL(new ProductVariantDAO()). Get10DiscountVariants();
            if (list.Count > 0)
            {
                cardSales.SafeInvoke(() =>
                {
                    cardSales.MaxChildren = list.Count;
                    cardSales.CustomLabelEnable = false;
                    cardSales.RemoveAllChild();
                    foreach (var item in list)
                    {
                        var product = new CardProduct(item.Id);
                        cardSales.AddLastChild(product);
                    }
                    cardSales.OnViewAllClicked += (s, e) =>
                    {
                        var control = new BrowseControl(BrowseControl.InputMode.SaleProduct);
                        MySystem.SetChildControl(control, "Xem sản phẩm giảm giá");
                    };
                });
            }
            else
            {
                cardSales.SafeInvoke(() => cardSales.Dispose());
            }
        }

        // Thiết lập sản phẩm mới
        private void SetUpNewProduct()
        {
            var dao = new ProductVariantDAO();
            var list = new ProductVariantBLL(dao).Get10LatestVariants();
            if (list.Count > 0)
            {
                cardNew.SafeInvoke(() =>
                {
                    cardNew.CustomLabelEnable = false;
                    cardNew.MaxChildren = list.Count;
                    cardNew.RemoveAllChild();
                    foreach (var item in list)
                    {
                        var product = new CardProduct(item.Id);
                        cardNew.AddLastChild(product);
                    }
                    cardNew.OnViewAllClicked += (s, e) =>
                    {
                        var control = new BrowseControl(BrowseControl.InputMode.NewProduct);
                        MySystem.SetChildControl(control, "Xem sản phẩm mới");
                    };
                });
            }
            else
            {
                cardNew.SafeInvoke(() => cardNew.Dispose());
            }
        }

        // Thiết lập sản phẩm gần đây
        private void SetUpRecentProduct()
        {
            List<long> list = JsonConvert.DeserializeObject<List<long>>(File.ReadAllText(".recent"));
            if (list == null)
            {
                list = new List<long>();
            }
            if (list.Count > 0)
            {
                cardRecent.SafeInvoke(() =>
                {
                    cardRecent.ActionButtonEnable = false;
                    cardRecent.CustomLabelEnable = false;
                    cardRecent.MaxChildren = list.Count;
                    cardRecent.RemoveAllChild();
                    foreach (var item in list)
                    {
                        var product = new CardProduct(item);
                        cardRecent.AddLastChild(product);
                    }
                });
            }
            else
            {
                cardRecent.SafeInvoke(() => cardRecent.Dispose());
            }
        }
    }
}
