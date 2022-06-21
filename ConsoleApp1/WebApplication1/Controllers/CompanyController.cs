using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            List<Company> companies = new List<Company>
            {
                new Company
                {
                    Name = "비플라이소프트",
                    Sector = "소프트웨어 개발 및 공급업",
                    MainProducts = "아이서퍼, 위고몬 등",
                    ListedDate = new DateTime(2022, 6, 20),
                    SettlementMonth = 12,
                    Ceo = "임경환",
                    Region = "서울특별시"
                },
                new Company
                {
                    Name = "범한퓨얼셀",
                    Sector = "전동기, 발전기 및 전기 변환 · 공급 · 제어 장치 제조업",
                    MainProducts = "잠수함용 연료전지모듈, 건물용 연료전지 시스템, 수소충전소 구축",
                    ListedDate = new DateTime(2022, 6, 17),
                    SettlementMonth = 12,
                    Ceo = "정영식",
                    Region = "경상남도"
                },
                new Company
                {
                    Name = "코나솔",
                    Sector = "특수 목적용 기계 제조업",
                    MainProducts = "합금강, 기계부품 제조",
                    ListedDate = new DateTime(2022, 6, 15),
                    SettlementMonth = 12,
                    Ceo = "강윤근",
                    Region = "충청남도"
                }
            };

            return View(companies);
        }
    }
}