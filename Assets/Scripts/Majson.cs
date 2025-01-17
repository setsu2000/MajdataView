﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class MajLoadedData
{
   static public List<SimaiTimingPoint> timingList = new List<SimaiTimingPoint>();
}

class Majson
{
    public List<SimaiTimingPoint> timingList = new List<SimaiTimingPoint>();
}

class SimaiTimingPoint
{
    public double time;
    public bool havePlayed;
    public int rawTextPositionX;
    public int rawTextPositionY;
    public string noteContent;
    public float currentBpm;
    public List<SimaiNote> noteList = new List<SimaiNote>();
}
enum SimaiNoteType
{
    Tap, Slide, Hold, Touch, TouchHold
}
class SimaiNote
{
    public SimaiNoteType noteType;
    public bool isBreak = false;
    public bool isHanabi = false;
    public int startPosition = 1; //键位（1-8）
    public char touchArea = ' ';
    public double holdTime = 0d;
    public double slideStartTime = 0d;
    public double slideTime = 0d;
    public string noteContent;
}

class EditRequestjson
{
    public EditorControlMethod control;
    public float startTime;
    public long startAt;
    public string jsonPath;
    public float playSpeed;
     public float backgroundCover;
}

enum EditorControlMethod
{
    Start, Stop
}
