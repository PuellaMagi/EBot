﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controllers;

namespace EBotPilot
{
    public partial class Form1 : Form
    {
        EBotManager _manager;

        #region Old Code
        //Frame eveFrame;
        //DateTime pulse;
        //Random random;
        //bool runOnce;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _manager = new EBotManager();

            #region Old Code
            //// Intialize
            //pulse = DateTime.MinValue;
            //random = new Random();

            //// Start up our interrupt of the eve frame
            //eveFrame = new EveModel.Frame();
            //eveFrame.OnFrame += new EventHandler(eveFrame_OnFrame);
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _manager.AddController(new TravelController());
        }

        #region Old Code
        //void eveFrame_OnFrame(object sender, EventArgs e)
        //{
            // Only make the wallet call once
            //if (runOnce)
            //    return;
            //runOnce = true;

            //// Obtain a refrence to the wallet service
            //var wallet = Frame.Client.GetService("wallet");

            //if (wallet.IsValid)
            //{
            //    eveFrame.Log("Found 'wallet' object with Intptr: " + wallet.PointerToObject);
            //    if (wallet["GetWealth"].IsValid)
            //    {
            //        eveFrame.Log("Found a 'GetWealth' attribute of type: " + wallet["GetWealth"].ObjectType);

            //        // Call the GetWealth method synchronously and interpret the result as a double
            //        EveObject balanceObj = wallet.CallMethod("GetWealth", new object[0]);
            //        eveFrame.Log("Found 'GetWealth' return type as: " + wallet.ObjectType);
            //        double balance = balanceObj.GetValueAs<double>();

            //        // Log balance to the innerspace console
            //        eveFrame.Log("Your balance is: " + balance.ToString("N"));
            //    }
            //}
            //else
            //{
            //    eveFrame.Log("Wallet service invalid, please start it first and try again");
            //}
        //}
        #endregion
    }
}
