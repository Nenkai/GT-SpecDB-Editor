﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syroot.BinaryData.Core;
using Syroot.BinaryData.Memory;

using GT_SpecDB_Editor.Core;
namespace GT_SpecDB_Editor.Mapping.Tables
{
    public class CarName : TableMetadata
    {
        public override string LabelPrefix { get; } = "";

        public CarName(SpecDBFolder folderType, string localeName)
        {
            Columns.Add(new ColumnMetadata("Name", DBColumnType.String, localeName));
            Columns.Add(new ColumnMetadata("Grade", DBColumnType.String, localeName));
            Columns.Add(new ColumnMetadata("ShortName", DBColumnType.String, localeName));

            if (folderType <= SpecDBFolder.GT5_TRIAL_JP2704)
                Columns.Add(new ColumnMetadata("NarrationID", DBColumnType.Int));
        }
    }
}
