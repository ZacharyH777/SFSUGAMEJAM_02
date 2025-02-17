/*
Class that handles currencies (Money, Intellect, Military Might)
Has getters and setters for all currencies as well as an add to function for easier simple math
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

static public class CurrenciesManager
{
    static int money = 0;
    static int intellect = 0;
    static int military = 0;
    static int favor = 0;

    public static void SetMoney(int sMoney){money = sMoney;}
    public static int GetMoney(){return money;}
    public static void AddMoney(int diff){money += diff;}

    public static void SetIntellect(int sIntellect){intellect = sIntellect;}
    public static int GetIntellect(){return intellect;}
    public static void AddIntellect(int diff){intellect += diff;}

    public static void SetMilitary(int sMilitary){military = sMilitary;}
    public static int GetMilitary(){return military;}
    public static void AddMilitary(int diff){military += diff;}

    public static void SetFavor(int sFavor){favor = sFavor;}
    public static int GetFavor(){return favor;}
    public static void AddFavor(int diff){favor += diff;}
}
