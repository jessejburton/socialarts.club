﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using socialarts.club.Data;
using socialarts.club.ViewComponents.Extensions;

namespace socialarts.club.Areas.Users.Pages
{
    // Currently, the current user's URL is socialarts.club/me because that is easy.
    // Options:
    // socialarts.club/me
    // socialarts.club/shaunluttin
    // socialarts.club/user
    // socialarts.club/users
    // socialarts.club/users/shaunluttin
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext db;

        private readonly UserManager<IdentityUser> userManager;

        public Dictionary<string, List<string>> ToolsDocuments { get; set; }

        public IndexModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        public void OnGet()
        {
            var currentUserId = userManager.GetUserId(User);
        }
    }
}
