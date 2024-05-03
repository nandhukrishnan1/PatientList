using System;
using System.Collections.Generic;

public class StudyDatum
{
    public int StudyID { get; set; }
    public DateTime StudyTime { get; set; }
    public int AccessionNumber { get; set; }
    public int Flag { get; set; }
    public string Modality { get; set; }
    public int Description { get; set; }
    public int NoOfImages { get; set; }
    public int RefferedPhysicianName { get; set; }

    //public List<SeriesDatum> SeriesData { get; set; }
}
