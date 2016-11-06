using Orchard.Localization;
using Orchard.UI.Notify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarkBartha.Bootstrap.Controllers
{
    public class TestController : Controller
    {
        public Localizer T { get; set; }

        private readonly INotifier _notifier;


        public TestController(INotifier notifier)
        {
            _notifier = notifier;
        }

        public ActionResult Index()
        {
            _notifier.Information(T("Test information"));
            _notifier.Information(T("Test information 2"));
            _notifier.Error(T("Test error"));
            _notifier.Warning(T("Test warning"));
            _notifier.Error(T("Test error"));
            _notifier.Information(T("Test information"));

            return Redirect("~/");
        }
    }
}