﻿namespace MySolution.Module.Mobile {
    partial class MySolutionMobileModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // MySolutionMobileModule
            // 
            this.RequiredModuleTypes.Add(typeof(MySolution.Module.MySolutionModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Mobile.SystemModule.SystemMobileModule));
        }

        #endregion
    }
}