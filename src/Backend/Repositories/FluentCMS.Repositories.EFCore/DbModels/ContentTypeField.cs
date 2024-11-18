﻿namespace FluentCMS.Repositories.EFCore.DbModels;

public class ContentTypeField
{
    public Guid Id { get; set; } // Primary Key
    public Guid ContentTypeId { get; set; } // Foreign key to Settings
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Type { get; set; } = default!;
    public bool Required { get; set; }
    public bool Unique { get; set; }
    public string Label { get; set; } = default!;
    public Dictionary<string, object?>? Settings { get; set; } = default!;

    // Navigation property
    public ContentType ContentType { get; set; } = default!;
}