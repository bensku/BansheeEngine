﻿using System;
using System.Collections.Generic;

namespace BansheeEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starts main editor window with the specified width/height and render system
            // (Window position and sizes are stored internally. Restored upon StartUp and saved upon ShutDown)
            //EditorApplication.StartUp(RenderSystem.DX11, 1024, 800);

            // TODO - A class to manipulate menu items

        }
    }

    //class SceneView : EditorWindow
    //{
       // SceneView()
    //    {
            // GUI is a GUILayout that is initialized internally by EditorWindow
            //GUI.AddButton("Some text");
            //GUI.AddXLayout();
            //GUI.CreateAreaFixed(100, 100, 400, 400); // GUIArea creating another GUIArea

            // Add support for GUIContent
            // Add support for GUILayoutOptions
            // Add support for GUIElementStyle and GUISkin - For now ignore this as I need to deal with Fonts, Textures, SpriteTextures, etc.
     //   }
    //}

    //class MyGUI : //GUIWidget // GUIWidget is automatically initialized with Game render window. Editor GUIWidgets are specially initialized 
    //{
        
    //}
}
