using AssignmentTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using AssignmentTest.Models;

namespace AssignmentTest.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        private ShopContext db = new ShopContext();
        public ActionResult Index()
        {
            return View((List<CartItem>)Session["giohang"]);
        }

        public ActionResult AddToCart(int id, int quantity)
        {
            Product product = db.Products.Find(id);

            if (quantity <= product.Quantity)
            {
                if (Session["giohang"] == null)
                {
                    Session["giohang"] = new List<CartItem>();

                }
                List<CartItem> giohang = Session["giohang"] as List<CartItem>;
                if (giohang.FirstOrDefault(m => m.proID == id) == null)
                {


                    CartItem cartItem = new CartItem()
                    {
                        proID = product.ID,
                        ProName = product.ProductName,
                        Price = product.Price,
                        Quantity = quantity,

                    };


                    giohang.Add(cartItem);
                    Debug.WriteLine(giohang.Count());

                }
                else
                {
                    CartItem cartItem = giohang.FirstOrDefault(m => m.proID == id);
                    cartItem.Quantity += quantity;
                }


                return Json(new
                {
                    code = 200,
                    message = "success",
                    JsonRequestBehavior.AllowGet
                });
            }
            else
            {
                return Json(new
                {
                    error = "Error msg",
                    JsonRequestBehavior.AllowGet

                });
            }
        }

        public ActionResult UpdateCart(int id, int quantity)
        {

            Debug.WriteLine(id);
            Debug.WriteLine(quantity);


            Product product = db.Products.Find(id);
            List<CartItem> giohang = Session["giohang"] as List<CartItem>;
            CartItem cartItem = giohang.FirstOrDefault(m => m.proID == id);

            if (quantity <= product.Quantity)
            {
                if (cartItem != null)
                {
                    cartItem.Quantity = quantity;

                    return Json(new
                    {
                        code = 200,
                        message = "success",
                        JsonRequestBehavior.AllowGet
                    });
                }
                else
                {
                    return Json(new
                    {
                        code = 400,
                        error = "Error msg",
                        JsonRequestBehavior.AllowGet
                    });
                }
            }
            else
            {
                return Json(new
                {

                    error = "Error msg",
                    JsonRequestBehavior.AllowGet
                });
            }



        }

        public ActionResult Remove(int Id)
        {
            List<CartItem> giohang = Session["giohang"] as List<CartItem>;
            giohang.RemoveAll(x => x.proID == Id);

            return Json(new
            {

                message = "success",
                JsonRequestBehavior.AllowGet
            });
        }

    }
}