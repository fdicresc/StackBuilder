﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Text;

using Sharp3D.Math.Core;
using TreeDim.StackBuilder.Basics;
#endregion

namespace TreeDim.StackBuilder.Engine
{
    class LayerPatternSpirale: LayerPattern
    {
        #region Implementation of LayerPattern abstract properties and methods
        public override string Name
        {
            get { return "Spirale"; }
        }

        public override void GetLayerDimensions(Layer layer, double palletLength, double palletWidth, out double actualLength, out double actualWidth)
        {
            actualLength = 0.0;
            actualWidth = 0.0;
        }

        public override void GenerateLayer(Layer layer, double palletLength, double palletWidth, double actualLength, double actualWidth)
        {
            double boxLength = layer.BoxLength;
            double boxWidth = layer.BoxWidth;
        }
        #endregion
    }
}
