using PokeBattleSupport2.Model;
using System.IO;

namespace PokeBattleSupport2.Shared;

public static class Common
{
    /// <summary>
    /// S種族値
    /// </summary>
    public enum SpeedRank
    {
        Fastest,
        Fast,
        Default,
        Slow,
        Slowest,
        Unknown
    }

    /// <summary>
    /// 持ち物
    /// </summary>
    public enum BattleItem
    {
        ChoiceScarf,
        None
    }

    public static readonly double[,] TypeEffectiveTable = new double[,]
    {
        {1,1,1,1,1,1,1,1,1,1,1,1,0.5,0,1,1,0.5,1 },
        {1,0.5,0.5,1,2,2,1,1,1,1,1,2,0.5,1,0.5,1,2,1},
        {1,2,0.5,1,0.5,1,1,1,2,1,1,1,2,1,0.5,1,1,1},
        {1,1,2,0.5,0.5,1,1,1,0,2,1,1,1,1,0.5,1,1,1},
        {1,0.5,2,1,0.5,1,1,0.5,2,0.5,1,0.5,2,1,0.5,1,0.5,1},
        {1,0.5,0.5,1,2,0.5,1,1,2,2,1,1,1,1,2,1,0.5,1},
        {2,1,1,1,1,2,1,0.5,1,0.5,0.5,0.5,2,0,1,2,2,0.5},
        {1,1,1,1,2,1,1,0.5,0.5,1,1,1,0.5,0.5,1,1,0,2},
        {1,2,1,2,0.5,1,1,2,1,0,1,0.5,2,1,1,1,2,1},
        {1,1,1,0.5,2,1,2,1,1,1,1,2,0.5,1,1,1,0.5,1},
        {1,1,1,1,1,1,2,2,1,1,0.5,1,1,1,1,0,0.5,1},
        {1,0.5,1,1,2,1,0.5,0.5,1,0.5,2,1,1,0.5,1,2,0.5,0.5},
        {1,2,1,1,1,2,0.5,1,0.5,2,1,2,1,1,1,1,0.5,1},
        {0,1,1,1,1,1,1,1,1,1,2,1,1,2,1,0.5,1,1},
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,0.5,0},
        {1,1,1,1,1,1,0.5,1,1,1,2,1,1,2,1,0.5,1,0.5},
        {1,0.5,0.5,0.5,1,2,1,1,1,1,1,1,2,1,1,1,0.5,2},
        { 1,0.5,1,1,1,1,2,0.5,1,1,1,1,1,1,2,2,0.5,1}
    };

    public static readonly string[] TypeNameList = new string[]
    {
        "ノーマル",
        "ほのお",
        "みず",
        "でんき",
        "くさ",
        "こおり",
        "かくとう",
        "どく",
        "じめん",
        "ひこう",
        "エスパー",
        "むし",
        "いわ",
        "ゴースト",
        "ドラゴン",
        "あく",
        "はがね",
        "フェアリー"
    };

    /// <summary>
    /// タイプ名称をインデックスに変換
    /// </summary>
    /// <param name="TypeName"></param>
    public static int ConvertTypeNameToIndex(string TypeName)
    {
        int index = 0;

        switch (TypeName)
        {
            case "ノーマル":
                index = 0;
                break;

            case "ほのお":
                index = 1;
                break;

            case "みず":
                index = 2;
                break;

            case "でんき":
                index = 3;
                break;

            case "くさ":
                index = 4;
                break;

            case "こおり":
                index = 5;
                break;

            case "かくとう":
                index = 6;
                break;

            case "どく":
                index = 7;
                break;

            case "じめん":
                index = 8;
                break;

            case "ひこう":
                index = 9;
                break;

            case "エスパー":
                index = 10;
                break;

            case "むし":
                index = 11;
                break;

            case "いわ":
                index = 12;
                break;

            case "ゴースト":
                index = 13;
                break;

            case "ドラゴン":
                index = 14;
                break;

            case "あく":
                index = 15;
                break;

            case "はがね":
                index = 16;
                break;

            case "フェアリー":
                index = 17;
                break;

            default:
                break;
        }

        return index;
    }

    /// <summary>
    /// 攻撃したときのタイプ相性による倍率の数値からマークを取得
    /// </summary>
    /// <param name="TypeEffectiveValue"></param>
    /// <returns></returns>
    public static TypeResistanceModel GetTypeResistance(double TypeEffectiveValue)
    {
        TypeResistanceModel mark = new();
        mark.EffectiveValue = TypeEffectiveValue;

        switch (TypeEffectiveValue)
        {
            case 4:
                mark.Mark = "▲";
                mark.MarkColor = MudBlazor.Color.Info;
                break;

            case 2:
                mark.Mark = "△";
                mark.MarkColor = MudBlazor.Color.Info;
                break;

            case 1:
                mark.Mark = "";
                mark.MarkColor = MudBlazor.Color.Secondary;
                break;

            case 0.5:
                mark.Mark = "○";
                mark.MarkColor = MudBlazor.Color.Secondary;
                break;

            case 0.25:
                mark.Mark = "◎";
                mark.MarkColor = MudBlazor.Color.Secondary;
                break;

            case 0:
                mark.Mark = "★";
                mark.MarkColor = MudBlazor.Color.Secondary;
                break;

            default:
                break;
        }

        return mark;
    }

    /// <summary>
    /// S実数値の計算
    /// </summary>
    /// <param name="baseStat"></param>
    /// <returns></returns>
    public static int CalcSpeedRealNumber(int baseStat, SpeedRank speedRank)
    {
        int realNumber = 0;
        if (baseStat == 0) return 0;

        switch (speedRank)
        {
            case SpeedRank.Fastest:
                // 最速
                realNumber = (int)Math.Floor((baseStat + 52) * 1.1);
                break;

            case SpeedRank.Fast:
                // 準速
                realNumber = baseStat + 52;
                break;

            case SpeedRank.Default:
                // 無振
                realNumber = baseStat + 20;
                break;

            case SpeedRank.Slow:
                // 下降
                realNumber = (int)Math.Floor((baseStat + 20) * 0.9);
                break;

            case SpeedRank.Slowest:
                // 最遅
                realNumber = (int)Math.Floor((baseStat + 5) * 0.9);
                break;
        }

        return realNumber;
    }
}
