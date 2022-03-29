using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionStorage : DataInput
{
    public DataStorage ds;
    // Start is called before the first frame update
    public override void changeData(object change)
    {
        if (change is string)
        {
            buttonName = change.ToString();
        }
    }

    public override void clearData()
    {
        buttonName = "ERROR";
        storeName = "ERROR";
    }

    public void SetData()
    {
        ds.addData(this.gameObject.name, storeName, true, this);
    }
    //[System.NonSerialized]
    public string buttonName = null;
    //[System.NonSerialized]
    public string storeName = null;
}