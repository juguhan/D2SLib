﻿namespace D2SLib.Model.Data;

public sealed class ItemStatCostData : DataFile
{
    public DataRow? this[int id] => GetByColumnAndValue("ID", id);
    public DataRow? this[string stat] => GetByColumnAndValue("Stat", stat);

    public static ItemStatCostData Read(Stream data)
    {
        var itemStatCost = new ItemStatCostData();
        itemStatCost.ReadData(data);
        return itemStatCost;
    }

    public static ItemStatCostData Read(string file)
    {
        using Stream stream = File.OpenRead(file);
        return Read(stream);
    }
}
