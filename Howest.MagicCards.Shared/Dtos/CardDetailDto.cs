﻿

namespace Howest.MagicCards.Shared.Dtos;

public class CardDetailDto : CardListDto
{
    public string ManaCost { get; set; }
    public string ConvertedManaCost { get; set; }
    public string Text { get; set; }
    public string Flavor { get; set; }
    public string Number { get; set; }
    public string Power { get; set; }
    public string Toughness { get; set; }
    public string Layout { get; set; }
    public int? MultiverseId { get; set; }
    public string OriginalImageUrl { get; set; }
    public string Image { get; set; }
    public string OriginalText { get; set; }
    public string OriginalType { get; set; }
    public string MtgId { get; set; }
    public string Variations { get; set; }
}

