using System;
using Microsoft.AspNetCore.Identity;
public class ApplicationUser : IdentityUser
{
    [PersonalData]
    public string FirstName { get; set; }

    [PersonalData]
    public string LastName { get; set; }
    [PersonalData]
    public int IsManager { get; set; }
    [PersonalData]
    public int IsTrainer { get; set; }
    [PersonalData]
    public int IsClient { get; set; }
    [PersonalData]
    public string Phone { get; set; }
    [PersonalData]
    public string Cell { get; set; }
    [PersonalData]
    public string Street { get; set; }
    [PersonalData]
    public string City { get; set; }
    [PersonalData]
    public string Province { get; set; }
    [PersonalData]
    public string Code { get; set; }
    [PersonalData]
    public string EmerFirstName { get; set; }
    [PersonalData]
    public string EmerLastName { get; set; }
    [PersonalData]
    public string EmerPhone1 { get; set; }
    [PersonalData]
    public string EmerPhone2 { get; set; }
    [PersonalData]
    public string Allergies { get; set; }
    [PersonalData]
    public string Injuries { get; set; }
    [PersonalData]
    public DateTime StartDate { get; set; }
}