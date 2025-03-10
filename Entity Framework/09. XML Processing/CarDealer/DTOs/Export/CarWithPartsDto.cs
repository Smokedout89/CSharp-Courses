﻿namespace CarDealer.DTOs.Export;

using System.Xml.Serialization;

[XmlType("car")]
public class CarWithPartsDto
{
    [XmlAttribute("make")]
    public string Make { get; set; } = null!;

    [XmlAttribute("model")]
    public string Model { get; set; } = null!;

    [XmlAttribute("traveled-distance")]
    public long TraveledDistance { get; set; }

    [XmlArray("parts")]
    public PartsDto[] Parts { get; set; }
}