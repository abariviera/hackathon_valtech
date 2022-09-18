using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;

namespace OneValtech.Feature.BasicComponents.Models.NavigationMenu
{
    [SitecoreType(true, Templates.NavigationMenu.ID, TemplateName = Templates.NavigationMenu.TemplateName)]
    public interface INavigationMenu
    {
        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreField(Templates.NavigationMenu.Fields.HeartImage, SitecoreFieldType.Image, "Data", FieldName = "Heart Image")]
        Image HeartImage { get; set; }
        
        [SitecoreField(Templates.NavigationMenu.Fields.MyProfileLink, SitecoreFieldType.GeneralLink, "Data", FieldName = "My Profile Link")]
        Link MyProfileLink { get; set; }
        
        [SitecoreField(Templates.NavigationMenu.Fields.AccountLink, SitecoreFieldType.GeneralLink, "Data", FieldName = "Account Link")]
        Link AccountLink { get; set; }

        [SitecoreField(Templates.NavigationMenu.Fields.HelpButtonText, SitecoreFieldType.SingleLineText, "Data", FieldName = "Help Button Text")]
        string HelpButtonText { get; set; }
    }
}
