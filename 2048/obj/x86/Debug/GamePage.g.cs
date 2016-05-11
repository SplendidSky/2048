﻿#pragma checksum "C:\Users\Administrator\2048\2048\GamePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7E0195488BDAC570B52DAF58F2D8EB29"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2048
{
    partial class GamePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class GamePage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGamePage_Bindings
        {
            private global::_2048.GamePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj32;
            private global::Windows.UI.Xaml.Controls.TextBlock obj34;
            private global::Windows.UI.Xaml.Controls.TextBlock obj35;

            private GamePage_obj1_BindingsTracking bindingsTracking;

            public GamePage_obj1_Bindings()
            {
                this.bindingsTracking = new GamePage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 32:
                        this.obj32 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 34:
                        this.obj34 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 35:
                        this.obj35 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IGamePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // GamePage_obj1_Bindings

            public void SetDataRoot(global::_2048.GamePage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::_2048.GamePage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_scores(obj.scores, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Player(obj.Player, phase);
                    }
                }
            }
            private void Update_scores(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj32, obj.ToString(), null);
                }
            }
            private void Update_Player(global::_2048.Models.player obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Player_Username(obj.Username, phase);
                        this.Update_Player_HighestScore(obj.HighestScore, phase);
                    }
                }
            }
            private void Update_Player_Username(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj34, obj, null);
                }
            }
            private void Update_Player_HighestScore(global::System.Int64 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj35, obj.ToString(), null);
                }
            }

            private class GamePage_obj1_BindingsTracking
            {
                global::System.WeakReference<GamePage_obj1_Bindings> WeakRefToBindingObj; 

                public GamePage_obj1_BindingsTracking(GamePage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<GamePage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    GamePage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::_2048.GamePage obj = sender as global::_2048.GamePage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_scores(obj.scores, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "scores":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_scores(obj.scores, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::_2048.GamePage obj)
                {
                    GamePage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.theBigGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 13 "..\..\..\GamePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.theBigGrid).Loaded += this.Grid_Loaded;
                    #line default
                }
                break;
            case 3:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4:
                {
                    this.VisualStateMin0 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.VisualStateMin960 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.VisualStateMin1280 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7:
                {
                    this.Information = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 8:
                {
                    this.Main = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.Record = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.RecordList = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.RecordofTheBest = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.TheBest = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13:
                {
                    this.row = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 14:
                {
                    this.b41 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 15:
                {
                    this.b42 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 16:
                {
                    this.b43 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 17:
                {
                    this.b44 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 18:
                {
                    this.b31 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 19:
                {
                    this.b32 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 20:
                {
                    this.b33 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 21:
                {
                    this.b34 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 22:
                {
                    this.b21 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 23:
                {
                    this.b22 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 24:
                {
                    this.b23 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 25:
                {
                    this.b24 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 26:
                {
                    this.col = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 27:
                {
                    this.b11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 28:
                {
                    this.b12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 29:
                {
                    this.b13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 30:
                {
                    this.b14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 31:
                {
                    this.GameTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 32:
                {
                    this.RecentScore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 33:
                {
                    this.UserHead = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 34:
                {
                    this.UserName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 35:
                {
                    this.PersonallyHighestScore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    GamePage_obj1_Bindings bindings = new GamePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

