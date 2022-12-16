﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = tm.TGetList();
            return View(values);
        }
    }
}
