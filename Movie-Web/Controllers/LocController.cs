using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie_Web.DAO;
using Movie_Web.Helpers;

namespace Movie_Web.Controllers
{
    public class LocController : Controller
    {
        // GET: Loc
        [HttpGet]
        public ActionResult Index(string id)
        {
            var filmdao = new FilmDAO();
            string url = (string)Url.RequestContext.RouteData.Values["id"];
            if (url=="hanh-dong")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Hành động", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);
                
            }
            else
            if (url == "khoa-hoc")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Khoa học", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "kinh-di")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Kinh dị", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "tinh-cam")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Tình cảm", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "anime")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Anime", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }

            else
            if (url == "co-trang")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Cổ trang", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }

            else
            if (url == "lich-su")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Lịch sử", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }

            else
            if (url == "chien-tranh")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Chiến tranh", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "hai-huoc")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Hài hước", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "kich-tinh")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Kịch tính", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "hinh-su")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Hình sự", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "the-thao")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmType("Thể thao", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }

            else
            if (url == "my")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Mỹ", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }

            else
            if (url == "trung-quoc")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Trung quốc", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }


            else
            if (url == "nga")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Nga", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }


            else
            if (url == "viet-nam")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Việt Nam", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "nhat")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Nhật", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "han")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Hàn quốc", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "an-do")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Ấn độ", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "chau-au")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Châu âu", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }

            else
            if (url == "thai-lan")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Thái lan", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "hong-kong")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Hồng Kông", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "hong-kong")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstFilmCountry("Hồng Kông", numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }

            else
            if (url == "phim-moi")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

                ViewBag.listfilmSlide = filmdao.listFilmSlideDescendingbyCreateDate(numrecords);

            }
            else
            if (url == "type-bo")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstBo("bo",numrecords);

                ViewBag.listfilmSlide = filmdao.lstBo("bo", numrecords);

            }
            else
            if (url == "type-le")
            {

                int numrecords = 10;
                ViewBag.listfilm = filmdao.lstBo("le",numrecords);

                ViewBag.listfilmSlide = filmdao.lstBo("le", numrecords);

            }

            else
            {
                ViewBag.listfilm = filmdao.listAllAdmin();
            }
            return View();
        }
    }
}