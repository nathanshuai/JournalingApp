using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JournalingApp.Models;
using Microsoft.AspNetCore.Identity;

namespace JournalingApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the JournalingAppUser class
public class JournalingAppUser : IdentityUser
{
    public List<Blogs> Blogs { get; set; } = new List<Blogs>();
}

