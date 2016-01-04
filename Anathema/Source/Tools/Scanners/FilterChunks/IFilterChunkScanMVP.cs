﻿using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema
{
    interface IFilterChunkScanView : IScannerView
    {
        // Methods invoked by the presenter (upstream)
    }

    abstract class IFilterChunkScanModel : IScannerModel
    {
        // Events triggered by the model (upstream)

        // Functions invoked by presenter (downstream)
        public abstract void SetMinChanges(Int32 MinChanges);
    }

    class FilterChunkScanPresenter : ScannerPresenter
    {
        new IFilterChunkScanView View;
        new IFilterChunkScanModel Model;

        public FilterChunkScanPresenter(IFilterChunkScanView View, IFilterChunkScanModel Model) : base(View, Model)
        {
            this.View = View;
            this.Model = Model;

            // Bind events triggered by the model

        }

        #region Method definitions called by the view (downstream)

        public void SetChunkSize(Int32 ChunkSize)
        {
            if (ChunkSize <= 0)
                return;
            
        }

        public void SetMinChanges(Int32 MinChanges)
        {
            if (MinChanges <= 0)
                return;

            Model.SetMinChanges(MinChanges);
        }

        #endregion

        #region Event definitions for events triggered by the model (upstream)

        #endregion
    }
}