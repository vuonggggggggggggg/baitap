using PhanThaiVuong_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhanThaiVuong_BigSchool.ViewModels
{
    public class FollowingViewModel
    {

        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}