using System;
using System.Collections.Generic;

public class PatientData
{
    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public DateTime StudyTime { get; set; }
    public int StudyId { get; set; }
    public string Modality { get; set; }
    public int ImageCount { get; set; }
    public string Description { get; set; }

    //public List<StudyDatum> StudyData { get; set; }
}
