using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Bonus types
/// </summary>
[Flags]
public enum BonusType
{
    None,
    DestroyWholeRowColumn
}


public static class BonusTypeUtilities
{
    /// <summary>
    /// Belirli bonus türünü kontrol etmek için yardımcı yöntem
    /// </summary>
    /// <param name="bt"></param>
    /// <returns></returns>
    public static bool ContainsDestroyWholeRowColumn(BonusType bt)
    {
        return (bt & BonusType.DestroyWholeRowColumn) 
            == BonusType.DestroyWholeRowColumn;
    }
}

/// <summary>
/// Basit oyun durumu
/// </summary>
public enum GameState
{
    None,
    SelectionStarted,
    Animating
}
