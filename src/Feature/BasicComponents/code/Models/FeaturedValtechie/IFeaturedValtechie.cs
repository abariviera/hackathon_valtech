using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;

namespace OneValtech.Feature.BasicComponents.Models.FeaturedValtechie
{
    [SitecoreType(true, Templates.FeaturedValtechie.ID, TemplateName = Templates.FeaturedValtechie.TemplateName)]
    public interface IFeaturedValtechie
    {
        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreField(Templates.FeaturedValtechie.Fields.HeartImage, SitecoreFieldType.Image, "Data", FieldName = "Heart Image")]
        Image HeartImage { get; set; }
        
        [SitecoreField(Templates.FeaturedValtechie.Fields.Title, SitecoreFieldType.SingleLineText, "Data", FieldName = "Title")]
        string Title { get; set; }
    }
}
