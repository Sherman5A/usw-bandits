﻿namespace USWBandits.models;

public class StartModel : IModel
{
    public ModelData ModelData { get; set; }

    public StartModel(ModelData modelData)
    {
        ModelData = modelData;
    }
}
