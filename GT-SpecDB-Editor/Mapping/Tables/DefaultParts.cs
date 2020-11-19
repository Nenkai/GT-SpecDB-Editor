﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syroot.BinaryData.Core;
using Syroot.BinaryData.Memory;

using GT_SpecDB_Editor.Mapping.Types;
namespace GT_SpecDB_Editor.Mapping.Tables
{
    public class DefaultParts : TableMetadata
    {
        public override string LabelPrefix { get; } = "df_pt_";

        public DefaultParts(string specdbName)
        {
            Columns.Add(new ColumnMetadata("Brake", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("BrakeCtrl", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Susp.", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ASCC", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("TCSC", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Chassis", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("R.Modify", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("L.weight", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Steer", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("DrvTrain", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Gear", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Engine", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("NA", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Turbo", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Displ.", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Computer", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Intercooler", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Muffler", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Clutch", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Flywheel", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Propel.", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("LSD", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("F. Tire", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("R. Tire", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("F.Tire_G", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("R.Tire_G", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("NOS", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Wing", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Aero", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("FlatFloor", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Freedom", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("L.Weight Window", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Bonnet", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("IntakeManifold", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ExhaustManifold", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Catalyst", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("AirCleaner", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("BoostControl", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("IndepThrottle", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("Supercharger", DBColumnType.Int));
            Columns.Add(new ColumnMetadata("ID", DBColumnType.Int));

            Columns.Add(new ColumnMetadata("Unk", DBColumnType.Short));
        }
    }
}