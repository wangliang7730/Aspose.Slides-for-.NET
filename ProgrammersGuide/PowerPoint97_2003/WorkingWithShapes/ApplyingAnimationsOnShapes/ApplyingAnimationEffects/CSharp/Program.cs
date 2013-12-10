//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;

namespace ApplyingAnimationEffects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate a Presentation object that represents a PPT file
            Presentation pres = new Presentation(dataDir + "demo.ppt");

            //Accessing a slide using its slide position
            Slide slide = pres.GetSlideByPosition(1);

            //Adding a rectangle shape into the slide by defining its X,Y postion, width
            //and height
            Shape shape = slide.Shapes.AddRectangle(1400, 1100, 3000, 2000);

            //Applying an animation effect on the rectangle shape
            shape.AnimationSettings.EntryEffect = ShapeEntryEffect.Spiral;

            //Writing the presentation as a PPT file
            pres.Write(dataDir + "modified.ppt");

            
        }
    }
}