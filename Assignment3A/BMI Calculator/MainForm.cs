using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class MainForm : Form
    {        
        
        /// <summary>
        /// Required designer variable.
        /// Create an instance variable of BMICalculator &
        /// an instance variable of SavingCalculator.
        /// </summary>
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingCalculator savingCalc = new SavingCalculator();
        private BMRCalculator bmrCalc = new BMRCalculator();
               
        
        /// <summary>
        /// Initialized method
        /// The MainForm constructor will run as soon as the GUI is created.
        /// </summary>        
        public MainForm()
        {
            InitializeComponent();//VS's initialization
            InitializeGUI(); //my initialization
            _MainForm = this;
        }
        public static MainForm _MainForm;
        public void update (string message)
        {
            txtName.Text = message;
            txtHeightFt.Text = message;
            txtHeightIn.Text = message;
            txtWeightLbs.Text = message;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBMI = new System.Windows.Forms.GroupBox();
            this.txtWeightLbs = new System.Windows.Forms.TextBox();
            this.txtHeightIn = new System.Windows.Forms.TextBox();
            this.txtHeightFt = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.grpSavingPlan = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblGrowth = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblMonthlyDep = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtGrowth = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMonthlyDep = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblNormalWeight = new System.Windows.Forms.Label();
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.lblWeightCat = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaving = new System.Windows.Forms.Button();
            this.grpFutureVal = new System.Windows.Forms.GroupBox();
            this.lblTotFees = new System.Windows.Forms.Label();
            this.lblFinBal = new System.Windows.Forms.Label();
            this.lblAmtEarned = new System.Windows.Forms.Label();
            this.lblAmtPd = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblFinalBal = new System.Windows.Forms.Label();
            this.lblAmountEarned = new System.Windows.Forms.Label();
            this.lblAmoutPaid = new System.Windows.Forms.Label();
            this.grpBMR = new System.Windows.Forms.GroupBox();
            this.listResults = new System.Windows.Forms.ListBox();
            this.btnBMR = new System.Windows.Forms.Button();
            this.grpWeekly = new System.Windows.Forms.GroupBox();
            this.rbtnSedentary = new System.Windows.Forms.RadioButton();
            this.rbtnLight = new System.Windows.Forms.RadioButton();
            this.rbtnModerate = new System.Windows.Forms.RadioButton();
            this.rbtnVery = new System.Windows.Forms.RadioButton();
            this.rbtnExtra = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnclear = new System.Windows.Forms.Button();
            this.grpBMI.SuspendLayout();
            this.grpUnit.SuspendLayout();
            this.grpSavingPlan.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.grpFutureVal.SuspendLayout();
            this.grpBMR.SuspendLayout();
            this.grpWeekly.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBMI
            // 
            this.grpBMI.Controls.Add(this.txtWeightLbs);
            this.grpBMI.Controls.Add(this.txtHeightIn);
            this.grpBMI.Controls.Add(this.txtHeightFt);
            this.grpBMI.Controls.Add(this.txtName);
            this.grpBMI.Controls.Add(this.lblWeight);
            this.grpBMI.Controls.Add(this.lblHeight);
            this.grpBMI.Controls.Add(this.label1);
            this.grpBMI.Location = new System.Drawing.Point(30, 8);
            this.grpBMI.Name = "grpBMI";
            this.grpBMI.Size = new System.Drawing.Size(389, 171);
            this.grpBMI.TabIndex = 1;
            this.grpBMI.TabStop = false;
            this.grpBMI.Text = "BMI Calculator";
            // 
            // txtWeightLbs
            // 
            this.txtWeightLbs.Location = new System.Drawing.Point(278, 115);
            this.txtWeightLbs.Name = "txtWeightLbs";
            this.txtWeightLbs.Size = new System.Drawing.Size(92, 26);
            this.txtWeightLbs.TabIndex = 5;
            this.txtWeightLbs.Tag = "TextBox";
            this.txtWeightLbs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtHeightIn
            // 
            this.txtHeightIn.Location = new System.Drawing.Point(278, 79);
            this.txtHeightIn.Name = "txtHeightIn";
            this.txtHeightIn.Size = new System.Drawing.Size(92, 26);
            this.txtHeightIn.TabIndex = 4;
            this.txtHeightIn.Tag = "TextBox";
            this.txtHeightIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtHeightFt
            // 
            this.txtHeightFt.Location = new System.Drawing.Point(164, 79);
            this.txtHeightFt.Name = "txtHeightFt";
            this.txtHeightFt.Size = new System.Drawing.Size(108, 26);
            this.txtHeightFt.TabIndex = 3;
            this.txtHeightFt.Tag = "TextBox";
            this.txtHeightFt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 26);
            this.txtName.TabIndex = 2;
            this.txtName.Tag = "TextBox";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(11, 113);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(141, 23);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight (lbs)";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeight
            // 
            this.lblHeight.Location = new System.Drawing.Point(11, 79);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(171, 26);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height (ft and in)";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rbtnImperial);
            this.grpUnit.Controls.Add(this.rbtnMetric);
            this.grpUnit.Location = new System.Drawing.Point(442, 14);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(184, 172);
            this.grpUnit.TabIndex = 0;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Location = new System.Drawing.Point(11, 70);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(142, 24);
            this.rbtnImperial.TabIndex = 1;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial (ft, lbs)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            this.rbtnImperial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(11, 40);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(137, 24);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric (kg, cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            this.rbtnMetric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // grpSavingPlan
            // 
            this.grpSavingPlan.Controls.Add(this.label2);
            this.grpSavingPlan.Controls.Add(this.lblFees);
            this.grpSavingPlan.Controls.Add(this.lblGrowth);
            this.grpSavingPlan.Controls.Add(this.lblPeriod);
            this.grpSavingPlan.Controls.Add(this.lblMonthlyDep);
            this.grpSavingPlan.Controls.Add(this.txtFees);
            this.grpSavingPlan.Controls.Add(this.txtGrowth);
            this.grpSavingPlan.Controls.Add(this.txtPeriod);
            this.grpSavingPlan.Controls.Add(this.txtMonthlyDep);
            this.grpSavingPlan.Controls.Add(this.txtBalance);
            this.grpSavingPlan.Location = new System.Drawing.Point(650, 14);
            this.grpSavingPlan.Name = "grpSavingPlan";
            this.grpSavingPlan.Size = new System.Drawing.Size(469, 205);
            this.grpSavingPlan.TabIndex = 6;
            this.grpSavingPlan.TabStop = false;
            this.grpSavingPlan.Text = "Saving plan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Initial Deposit";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(19, 162);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(79, 20);
            this.lblFees.TabIndex = 8;
            this.lblFees.Text = "Fees in %";
            // 
            // lblGrowth
            // 
            this.lblGrowth.AutoSize = true;
            this.lblGrowth.Location = new System.Drawing.Point(19, 130);
            this.lblGrowth.Name = "lblGrowth";
            this.lblGrowth.Size = new System.Drawing.Size(180, 20);
            this.lblGrowth.TabIndex = 7;
            this.lblGrowth.Text = "Growth (or interest) in %";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(19, 98);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(106, 20);
            this.lblPeriod.TabIndex = 6;
            this.lblPeriod.Text = "Period (years)";
            // 
            // lblMonthlyDep
            // 
            this.lblMonthlyDep.AutoSize = true;
            this.lblMonthlyDep.Location = new System.Drawing.Point(19, 65);
            this.lblMonthlyDep.Name = "lblMonthlyDep";
            this.lblMonthlyDep.Size = new System.Drawing.Size(120, 20);
            this.lblMonthlyDep.TabIndex = 5;
            this.lblMonthlyDep.Text = "Monthly deposit";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(225, 156);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(226, 26);
            this.txtFees.TabIndex = 4;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtGrowth
            // 
            this.txtGrowth.Location = new System.Drawing.Point(225, 124);
            this.txtGrowth.Name = "txtGrowth";
            this.txtGrowth.Size = new System.Drawing.Size(226, 26);
            this.txtGrowth.TabIndex = 3;
            this.txtGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrowth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(225, 92);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(226, 26);
            this.txtPeriod.TabIndex = 2;
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeriod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtMonthlyDep
            // 
            this.txtMonthlyDep.Location = new System.Drawing.Point(225, 59);
            this.txtMonthlyDep.Name = "txtMonthlyDep";
            this.txtMonthlyDep.Size = new System.Drawing.Size(226, 26);
            this.txtMonthlyDep.TabIndex = 1;
            this.txtMonthlyDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonthlyDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(225, 27);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(226, 26);
            this.txtBalance.TabIndex = 0;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(30, 188);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(389, 31);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Calculate BMI";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblNormalWeight);
            this.grpResult.Controls.Add(this.lblNormalBMI);
            this.grpResult.Controls.Add(this.lblWeightCat);
            this.grpResult.Controls.Add(this.lbl);
            this.grpResult.Controls.Add(this.lblbmi);
            this.grpResult.Controls.Add(this.label8);
            this.grpResult.Location = new System.Drawing.Point(28, 264);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(598, 195);
            this.grpResult.TabIndex = 5;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Results for";
            // 
            // lblNormalWeight
            // 
            this.lblNormalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNormalWeight.ForeColor = System.Drawing.Color.Black;
            this.lblNormalWeight.Location = new System.Drawing.Point(2, 162);
            this.lblNormalWeight.Name = "lblNormalWeight";
            this.lblNormalWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNormalWeight.Size = new System.Drawing.Size(596, 30);
            this.lblNormalWeight.TabIndex = 13;
            this.lblNormalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNormalBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNormalBMI.Location = new System.Drawing.Point(1, 121);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNormalBMI.Size = new System.Drawing.Size(597, 30);
            this.lblNormalBMI.TabIndex = 12;
            this.lblNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeightCat
            // 
            this.lblWeightCat.AutoSize = true;
            this.lblWeightCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCat.Location = new System.Drawing.Point(253, 79);
            this.lblWeightCat.Name = "lblWeightCat";
            this.lblWeightCat.Size = new System.Drawing.Size(2, 22);
            this.lblWeightCat.TabIndex = 11;
            this.lblWeightCat.Tag = "TextBox";
            this.lblWeightCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWeightCat.Click += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(11, 81);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(151, 23);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Weight Category";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblbmi
            // 
            this.lblbmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbmi.Location = new System.Drawing.Point(253, 32);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(120, 25);
            this.lblbmi.TabIndex = 9;
            this.lblbmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "BMI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(231, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // btnSaving
            // 
            this.btnSaving.AutoSize = true;
            this.btnSaving.Location = new System.Drawing.Point(686, 225);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(301, 31);
            this.btnSaving.TabIndex = 7;
            this.btnSaving.Text = "Calculate saving";
            this.btnSaving.UseVisualStyleBackColor = true;
            this.btnSaving.Click += new System.EventHandler(this.btnSaving_Click);
            this.btnSaving.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // grpFutureVal
            // 
            this.grpFutureVal.Controls.Add(this.lblTotFees);
            this.grpFutureVal.Controls.Add(this.lblFinBal);
            this.grpFutureVal.Controls.Add(this.lblAmtEarned);
            this.grpFutureVal.Controls.Add(this.lblAmtPd);
            this.grpFutureVal.Controls.Add(this.lblTotalFees);
            this.grpFutureVal.Controls.Add(this.lblFinalBal);
            this.grpFutureVal.Controls.Add(this.lblAmountEarned);
            this.grpFutureVal.Controls.Add(this.lblAmoutPaid);
            this.grpFutureVal.Location = new System.Drawing.Point(656, 275);
            this.grpFutureVal.Name = "grpFutureVal";
            this.grpFutureVal.Size = new System.Drawing.Size(463, 184);
            this.grpFutureVal.TabIndex = 8;
            this.grpFutureVal.TabStop = false;
            this.grpFutureVal.Text = "Future value";
            // 
            // lblTotFees
            // 
            this.lblTotFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotFees.Location = new System.Drawing.Point(219, 125);
            this.lblTotFees.Name = "lblTotFees";
            this.lblTotFees.Size = new System.Drawing.Size(226, 25);
            this.lblTotFees.TabIndex = 20;
            this.lblTotFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinBal
            // 
            this.lblFinBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinBal.Location = new System.Drawing.Point(219, 90);
            this.lblFinBal.Name = "lblFinBal";
            this.lblFinBal.Size = new System.Drawing.Size(226, 25);
            this.lblFinBal.TabIndex = 19;
            this.lblFinBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmtEarned
            // 
            this.lblAmtEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmtEarned.Location = new System.Drawing.Point(219, 58);
            this.lblAmtEarned.Name = "lblAmtEarned";
            this.lblAmtEarned.Size = new System.Drawing.Size(226, 25);
            this.lblAmtEarned.TabIndex = 18;
            this.lblAmtEarned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmtPd
            // 
            this.lblAmtPd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmtPd.Location = new System.Drawing.Point(219, 29);
            this.lblAmtPd.Name = "lblAmtPd";
            this.lblAmtPd.Size = new System.Drawing.Size(226, 25);
            this.lblAmtPd.TabIndex = 17;
            this.lblAmtPd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(12, 127);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(79, 20);
            this.lblTotalFees.TabIndex = 16;
            this.lblTotalFees.Text = "Total fees";
            // 
            // lblFinalBal
            // 
            this.lblFinalBal.AutoSize = true;
            this.lblFinalBal.Location = new System.Drawing.Point(12, 95);
            this.lblFinalBal.Name = "lblFinalBal";
            this.lblFinalBal.Size = new System.Drawing.Size(103, 20);
            this.lblFinalBal.TabIndex = 15;
            this.lblFinalBal.Text = "Final balance";
            // 
            // lblAmountEarned
            // 
            this.lblAmountEarned.AutoSize = true;
            this.lblAmountEarned.Location = new System.Drawing.Point(12, 63);
            this.lblAmountEarned.Name = "lblAmountEarned";
            this.lblAmountEarned.Size = new System.Drawing.Size(119, 20);
            this.lblAmountEarned.TabIndex = 14;
            this.lblAmountEarned.Text = "Amount earned";
            // 
            // lblAmoutPaid
            // 
            this.lblAmoutPaid.AutoSize = true;
            this.lblAmoutPaid.Location = new System.Drawing.Point(12, 30);
            this.lblAmoutPaid.Name = "lblAmoutPaid";
            this.lblAmoutPaid.Size = new System.Drawing.Size(99, 20);
            this.lblAmoutPaid.TabIndex = 13;
            this.lblAmoutPaid.Text = "Amount paid";
            // 
            // grpBMR
            // 
            this.grpBMR.Controls.Add(this.listResults);
            this.grpBMR.Controls.Add(this.btnBMR);
            this.grpBMR.Controls.Add(this.grpWeekly);
            this.grpBMR.Controls.Add(this.txtAge);
            this.grpBMR.Controls.Add(this.lblAge);
            this.grpBMR.Controls.Add(this.grpGender);
            this.grpBMR.Location = new System.Drawing.Point(28, 483);
            this.grpBMR.Name = "grpBMR";
            this.grpBMR.Size = new System.Drawing.Size(1091, 311);
            this.grpBMR.TabIndex = 5;
            this.grpBMR.TabStop = false;
            this.grpBMR.Text = "BMR Calculator";
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.ItemHeight = 20;
            this.listResults.Location = new System.Drawing.Point(522, 22);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(563, 224);
            this.listResults.TabIndex = 5;
            // 
            // btnBMR
            // 
            this.btnBMR.AutoSize = true;
            this.btnBMR.Location = new System.Drawing.Point(129, 217);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(327, 44);
            this.btnBMR.TabIndex = 4;
            this.btnBMR.Text = "Calculate BMR";
            this.btnBMR.UseVisualStyleBackColor = true;
            // 
            // grpWeekly
            // 
            this.grpWeekly.Controls.Add(this.rbtnSedentary);
            this.grpWeekly.Controls.Add(this.rbtnLight);
            this.grpWeekly.Controls.Add(this.rbtnModerate);
            this.grpWeekly.Controls.Add(this.rbtnVery);
            this.grpWeekly.Controls.Add(this.rbtnExtra);
            this.grpWeekly.Location = new System.Drawing.Point(166, 25);
            this.grpWeekly.Name = "grpWeekly";
            this.grpWeekly.Size = new System.Drawing.Size(344, 173);
            this.grpWeekly.TabIndex = 3;
            this.grpWeekly.TabStop = false;
            this.grpWeekly.Text = "Weekly activity level";
            // 
            // rbtnSedentary
            // 
            this.rbtnSedentary.AutoSize = true;
            this.rbtnSedentary.Location = new System.Drawing.Point(11, 25);
            this.rbtnSedentary.Name = "rbtnSedentary";
            this.rbtnSedentary.Size = new System.Drawing.Size(251, 24);
            this.rbtnSedentary.TabIndex = 0;
            this.rbtnSedentary.TabStop = true;
            this.rbtnSedentary.Text = "Sedentary (little or no exercise)";
            this.rbtnSedentary.UseVisualStyleBackColor = true;
            this.rbtnSedentary.CheckedChanged += new System.EventHandler(this.rbtnSedentary_CheckedChanged);
            // 
            // rbtnLight
            // 
            this.rbtnLight.AutoSize = true;
            this.rbtnLight.Location = new System.Drawing.Point(12, 55);
            this.rbtnLight.Name = "rbtnLight";
            this.rbtnLight.Size = new System.Drawing.Size(274, 24);
            this.rbtnLight.TabIndex = 1;
            this.rbtnLight.TabStop = true;
            this.rbtnLight.Text = "Lightly active (1 to 3 times a week)";
            this.rbtnLight.UseVisualStyleBackColor = true;
            this.rbtnLight.CheckedChanged += new System.EventHandler(this.rbtnLight_CheckedChanged);
            // 
            // rbtnModerate
            // 
            this.rbtnModerate.AutoSize = true;
            this.rbtnModerate.Location = new System.Drawing.Point(11, 85);
            this.rbtnModerate.Name = "rbtnModerate";
            this.rbtnModerate.Size = new System.Drawing.Size(307, 24);
            this.rbtnModerate.TabIndex = 2;
            this.rbtnModerate.TabStop = true;
            this.rbtnModerate.Text = "Moderately active (3 to 5 times a week)";
            this.rbtnModerate.UseVisualStyleBackColor = true;
            this.rbtnModerate.CheckedChanged += new System.EventHandler(this.rbtnModerate_CheckedChanged);
            // 
            // rbtnVery
            // 
            this.rbtnVery.AutoSize = true;
            this.rbtnVery.Location = new System.Drawing.Point(12, 115);
            this.rbtnVery.Name = "rbtnVery";
            this.rbtnVery.Size = new System.Drawing.Size(261, 24);
            this.rbtnVery.TabIndex = 3;
            this.rbtnVery.TabStop = true;
            this.rbtnVery.Text = "Very active (6 to 7 times a week)";
            this.rbtnVery.UseVisualStyleBackColor = true;
            this.rbtnVery.CheckedChanged += new System.EventHandler(this.rbtnVery_CheckedChanged);
            // 
            // rbtnExtra
            // 
            this.rbtnExtra.AutoSize = true;
            this.rbtnExtra.Location = new System.Drawing.Point(11, 145);
            this.rbtnExtra.Name = "rbtnExtra";
            this.rbtnExtra.Size = new System.Drawing.Size(329, 24);
            this.rbtnExtra.TabIndex = 4;
            this.rbtnExtra.TabStop = true;
            this.rbtnExtra.Text = "Extra active, hard exercises or physical job";
            this.rbtnExtra.UseVisualStyleBackColor = true;
            this.rbtnExtra.CheckedChanged += new System.EventHandler(this.rbtnExtra_CheckedChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(84, 148);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(69, 26);
            this.txtAge.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 148);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbtnMale);
            this.grpGender.Controls.Add(this.rbtnFemale);
            this.grpGender.Location = new System.Drawing.Point(8, 25);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(145, 97);
            this.grpGender.TabIndex = 0;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(17, 55);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(68, 24);
            this.rbtnMale.TabIndex = 1;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(17, 25);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(87, 24);
            this.rbtnFemale.TabIndex = 0;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.Location = new System.Drawing.Point(993, 225);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(85, 31);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1127, 806);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.grpBMR);
            this.Controls.Add(this.grpFutureVal);
            this.Controls.Add(this.btnSaving);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpSavingPlan);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.grpBMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator by Gloria Palm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBMI.ResumeLayout(false);
            this.grpBMI.PerformLayout();
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpSavingPlan.ResumeLayout(false);
            this.grpSavingPlan.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpFutureVal.ResumeLayout(false);
            this.grpFutureVal.PerformLayout();
            this.grpBMR.ResumeLayout(false);
            this.grpBMR.PerformLayout();
            this.grpWeekly.ResumeLayout(false);
            this.grpWeekly.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }        
        #endregion
        private GroupBox grpSavingPlan;
        private Label lblWeight;
        private Label lblHeight;
        private Label label1;
        private Label lblFees;
        private Label lblGrowth;
        private Label lblPeriod;
        private Label lblMonthlyDep;
        private TextBox txtFees;
        private TextBox txtGrowth;
        private TextBox txtPeriod;
        private TextBox txtMonthlyDep;
        private GroupBox grpResult;
        private Label lblWeightCat;
        private Label lbl;
        private Label lblbmi;
        private Label label8;
        
        /// <summary>
        /// Initialize the GUI with some preset options
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Calculator by Gloria Palm";
            lblbmi.Text = string.Empty;
            lblWeightCat.Text = string.Empty;
            lblNormalBMI.Text = string.Empty;
            lblNormalWeight.Text = string.Empty;           
            txtName.ForeColor = Color.LightGray;
            txtName.Text = "Please Enter Name";
            this.txtName.Leave += new  EventHandler(this.TxtName_Leave);
            this.txtName.Enter += new EventHandler(this.TxtName_Enter);
            txtHeightFt.ForeColor = Color.LightGray;
            txtHeightFt.Text = "Feet";            
            txtHeightFt.TextAlign = HorizontalAlignment.Center;
            this.txtHeightFt.Leave += new EventHandler(this.TxtHeightFt_Leave);
            this.txtHeightFt.Enter += new EventHandler(this.TxtHeightFt_Enter);
            txtHeightIn.ForeColor = Color.LightGray;
            txtHeightIn.Text = "Inches";
            txtHeightIn.TextAlign = HorizontalAlignment.Center;
            this.txtHeightIn.Leave += new EventHandler(this.TxtHeightIn_Leave);
            this.txtHeightIn.Enter += new EventHandler(this.TxtHeightIn_Enter);
            txtWeightLbs.ForeColor = Color.LightGray;
            txtWeightLbs.Text = "Pounds";
            txtWeightLbs.TextAlign = HorizontalAlignment.Center;
            this.txtWeightLbs.Leave += new EventHandler(this.TxtWeightLbs_Leave);
            this.txtWeightLbs.Enter += new EventHandler(this.TxtWeightLbs_Enter);
            lblAmtPd.Text = string.Empty;
            lblAmtEarned.Text = string.Empty;
            lblFinBal.Text = string.Empty;
            lblTotFees.Text = string.Empty;
            txtBalance.ForeColor = Color.LightGray;
            txtBalance.Text = "0.00";           
            this.txtBalance.Leave += new EventHandler(this.TxtBalance_Leave);
            this.txtBalance.Enter += new EventHandler(this.TxtBalance_Enter);
            txtMonthlyDep.ForeColor = Color.LightGray;
            txtMonthlyDep.Text = "0.00";
            this.txtMonthlyDep.Leave += new EventHandler(this.TxtMonthlyDep_Leave);
            this.txtMonthlyDep.Enter += new EventHandler(this.TxtMonthlyDep_Enter);
            txtPeriod.ForeColor = Color.LightGray;
            txtPeriod.Text = "0.00";
            this.txtPeriod.Leave += new EventHandler(this.TxtPeriod_Leave);
            this.txtPeriod.Enter += new EventHandler(this.TxtPeriod_Enter);            
            txtGrowth.Text = "%";            
            this.txtGrowth.Leave += new EventHandler(this.TxtGrowth_Leave);
            this.txtGrowth.Enter += new EventHandler(this.TxtGrowth_Enter);
            txtFees.Text = "%";            
            this.txtFees.Leave += new EventHandler(this.TxtFees_Leave);
            this.txtFees.Enter += new EventHandler(this.TxtFees_Enter);

        }        
        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Anonymous";
                txtName.ForeColor = Color.Gray;                
            }
        }
        private void TxtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Please Enter Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }
        private void TxtHeightFt_Leave(object sender, EventArgs e)
        {
            if (txtHeightFt.Text == "") 
            {
                txtHeightFt.Text = "Feet";
                txtHeightFt.ForeColor = Color.Gray; 
                if (rbtnImperial.Checked == false)
                {
                    txtHeightFt.Text = "Centemeters";
                    txtHeightFt.ForeColor = Color.Gray;
                }                
            }
        }
        private void TxtHeightFt_Enter(object sender, EventArgs e)
        {
            if (txtHeightFt.Text == "Feet")
            {
                txtHeightFt.Text = "";
                txtHeightFt.ForeColor = Color.Black;                
            }
            else 
            {
                txtHeightFt.Text = "";
                txtHeightFt.ForeColor = Color.Black;
                rbtnImperial.Checked = false;
            }
        }
        private void TxtHeightIn_Leave(object sender, EventArgs e)
        {
            if (txtHeightIn.Text == "")
            {
                txtHeightIn.Text = "Inches";
                txtHeightIn.ForeColor = Color.Gray;
            }
        }
        private void TxtHeightIn_Enter(object sender, EventArgs e)
        {
            if (txtHeightIn.Text == "Inches")
            {
                txtHeightIn.Text = "";
                txtHeightIn.ForeColor = Color.Black;
            }
        }
        private void TxtWeightLbs_Leave(object sender, EventArgs e)
        {
            if (txtWeightLbs.Text == "")
            {
                txtWeightLbs.Text = "Pounds";
                txtWeightLbs.ForeColor = Color.Gray;
                if (rbtnImperial.Checked == false)
                {
                    txtWeightLbs.Text = "Kilograms";
                    txtWeightLbs.ForeColor = Color.Gray;
                }
            }
        }
        private void TxtWeightLbs_Enter(object sender, EventArgs e)
        {
            if (txtWeightLbs.Text == "Pounds")
            {
                txtWeightLbs.Text = "";
                txtWeightLbs.ForeColor = Color.Black;
            }
            else
            {
                txtWeightLbs.Text = "";
                txtWeightLbs.ForeColor = Color.Black;
                rbtnImperial.Checked = false;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text.Trim();
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                bmiCalc.Name = txtName.Text;
                bmrCalc.Name = txtName.Text;
            }                
            else
            {                
                bmiCalc.Name = "Anonymous";
                bmrCalc.Name = "Anonymous";
            }                
        }
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
        }

        private void UpdateHeightText()
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                txtHeightIn.Visible = false;
                txtHeightFt.Text = "Centemeters";
                txtHeightFt.ForeColor = Color.Gray;
                txtWeightLbs.Text = "Kilograms";
                txtWeightLbs.ForeColor = Color.Gray;
                bmiCalc.SetUnit1(UnitTypes.Metric);
                bmrCalc.SetUnit1(UnitTypes.Metric);
            }
            else
            {
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbs)";
                txtHeightIn.Visible = true;
                txtHeightFt.Text = "Feet";
                txtHeightFt.ForeColor = Color.Gray;
                txtHeightIn.Text = "Inches";
                txtHeightIn.ForeColor = Color.Gray;
                txtWeightLbs.Text = "Pounds";
                txtWeightLbs.ForeColor = Color.Gray;
                bmiCalc.SetUnit1(UnitTypes.Imperial);
                bmrCalc.SetUnit1(UnitTypes.Imperial);
            }            
        }
        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender();
        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender();
        }
        private void UpdateGender()
        {
            if (rbtnFemale.Checked)
                bmrCalc.Gender = GenderTypes.Female;
            if (rbtnMale.Checked)
                bmrCalc.Gender = GenderTypes.Male;
        }
        private void rbtnSedentary_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel();
        }

        private void rbtnLight_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel();
        }

        private void rbtnModerate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel();
        }

        private void rbtnVery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel();
        }

        private void rbtnExtra_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel();
        }
        private void UpdateLevel()
        {
            if (rbtnSedentary.Checked)
                bmrCalc.SetActivity(ActivityTypes.Sedentary);
            else if (rbtnLight.Checked)
                bmrCalc.SetActivity(ActivityTypes.LightlyActive);
            else if (rbtnModerate.Checked)
                bmrCalc.SetActivity(ActivityTypes.ModeratelyActive);
            else if (rbtnVery.Checked)
                bmrCalc.SetActivity(ActivityTypes.VeryActive);
            else if (rbtnExtra.Checked)
                bmrCalc.SetActivity(ActivityTypes.ExtraActive);
        }        
        private void btnOk_Click(object sender, EventArgs e)
        {            
            //1. read input
            bool ok = ReadInput();

            //2. calculate
            if (ok)
            {
                //calculate and display results.
                CalculateAndDisplayResults();
            }
            //Display the results from the calculation
            //3. show results
           
        }                
        private bool ReadInput()
        {
            ReadName();
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();            

            return heightOK && weightOK;
        }
        private void ReadName()
        {
            bmiCalc.SetName(txtName.Text);            
        }            
        private bool ReadHeight()
        {
            double height = 0.0;
            double inch = 0.0;

            bool ok = double.TryParse(txtHeightFt.Text, out height);
            if (!ok)
            {
                MessageBox.Show("The height value is invalid", "Error");
            }
            
            if (rbtnImperial.Checked)
            {
                ok = double.TryParse(txtHeightIn.Text, out inch);
                if (!ok)
                {
                    MessageBox.Show("The inch value is invalid", "Error");
                }
            }
            if (bmiCalc.GetUnit1() == UnitTypes.Imperial)
            {
                height = height * 12.0 + inch; //ft --> in
            }
            else if (bmiCalc.GetUnit1() == UnitTypes.Metric)
            {
                height = height / 100.0; //cm --> m
            }
            bmiCalc.SetHeight(height);            
            return ok;
        }
        private bool ReadWeight()
        {
            double weight = 0.0;

            bool ok = double.TryParse(txtWeightLbs.Text, out weight);
            if (!ok) //ok == false
            {
                MessageBox.Show("The weight value is invalid", "Error");
            }
            bmiCalc.SetWeight(weight);          
            return ok;
        } 

        private void CalculateAndDisplayResults()
        {
            grpResult.Text = "Results for " + bmiCalc.GetName();            
            lblbmi.Text = bmiCalc.CalculateBMI().ToString("f2");
            lblWeightCat.Text = bmiCalc.BmiWeightCategory().ToString();
            lblNormalBMI.Text = "Normal BMI is between 18.50 and 24.90";
            lblNormalWeight.Text = bmiCalc.BmiNormalWeight();            
        }
        private void btnBMR_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBmr();

            //2. calculate
            if (ok)
            {
                //calculate and display results.
                CalculateAndDisplayBmrResults();
            }
            //Display the results from the calculation
            //3. show results

        }
        private bool ReadInputBmr()
        {
            ReadNameBmr();
            bool heightOK = ReadHeightBmr();
            bool weightOK = ReadWeightBmr();
            bool ageOK = ReadAgeBmr();

            return heightOK && weightOK && ageOK;
        }
        private void ReadNameBmr()
        {
            bmrCalc.SetName(txtName.Text);
        }
        private bool ReadHeightBmr()
        {
            double height = 0.0;
            double inch = 0.0;

            bool ok = double.TryParse(txtHeightFt.Text, out height);
            if (!ok)
            {
                MessageBox.Show("The height value is invalid", "Error");
            }

            if (rbtnImperial.Checked)
            {
                ok = double.TryParse(txtHeightIn.Text, out inch);
                if (!ok)
                {
                    MessageBox.Show("The inch value is invalid", "Error");
                }
            }
            if (bmrCalc.GetUnit1() == UnitTypes.Imperial)
            {
                height = (height * 12.0 + inch) * 2.54; //ft --> in
            }            
            bmrCalc.SetHeight(height);
            return ok;
        }
        private bool ReadWeightBmr()
        {
            double weight = 0.0;

            bool ok = double.TryParse(txtWeightLbs.Text, out weight);
            if (!ok) //ok == false
            {
                MessageBox.Show("The weight value is invalid", "Error");
            }
            if (bmrCalc.GetUnit1() == UnitTypes.Imperial)
            {
                weight = weight * 0.45359237; //ft --> in
            }
            bmrCalc.SetWeight(weight);
            return ok;
        }
        private bool ReadAgeBmr()
        {
            double age = 0.0;

            bool ok = double.TryParse(txtAge.Text, out age);
            if (!ok) //ok == false
            {
                MessageBox.Show("The age value is invalid", "Error");
            }            
            bmrCalc.SetAge(age);
            return ok;
        }
        private void CalculateAndDisplayBmrResults()
        {
            listResults.Items.Add("BMR RESULTS FOR " + bmrCalc.GetName().ToUpper());
            listResults.Items.Add("Your BMR (calories/day) " + bmrCalc.CalculateBMR().ToString("f2"));
            listResults.Items.Add("Calories to maintain your weight " + bmrCalc.CalculateCalToMaintain().ToString("f2"));
            listResults.Items.Add("Calories to lose 0.5 kg. per week " + bmrCalc.CalculateCalToLose1().ToString("f2"));
            listResults.Items.Add("Calories to lose 1 kg. per week " + bmrCalc.CalculateCalToLose2().ToString("f2"));
            listResults.Items.Add("Calories to gain 0.5 kg. per week " + bmrCalc.CalculateCalToGain1().ToString("f2"));
            listResults.Items.Add("Calories to gain 1 kg. per week " + bmrCalc.CalculateCalToGain2().ToString("f2"));
            listResults.Items.Add("Losing more than 1000 calories per day is to be avoided.");
        }

        private void TxtBalance_Leave(object sender, EventArgs e)
        {
            if (txtBalance.Text == "")
            {
                txtBalance.Text = "0.00";
                txtBalance.ForeColor = Color.Gray;
            }
        }
        private void TxtBalance_Enter(object sender, EventArgs e)
        {
            if (txtBalance.Text == "0.00")
            {
                txtBalance.Text = "";
                txtBalance.ForeColor = Color.Black;                
            }
        }
        private void TxtMonthlyDep_Leave(object sender, EventArgs e)
        {
            if (txtMonthlyDep.Text == "")
            {
                txtMonthlyDep.Text = "0.00";
                txtMonthlyDep.ForeColor = Color.Gray;
            }
        }
        private void TxtMonthlyDep_Enter(object sender, EventArgs e)
        {
            if (txtMonthlyDep.Text == "0.00")
            {
                txtMonthlyDep.Text = "";
                txtMonthlyDep.ForeColor = Color.Black;
            }
        }
        private void TxtPeriod_Leave(object sender, EventArgs e)
        {
            if (txtPeriod.Text == "")
            {
                txtPeriod.Text = "0.00";
                txtPeriod.ForeColor = Color.Gray;
            }
        }
        private void TxtPeriod_Enter(object sender, EventArgs e)
        {
            if (txtPeriod.Text == "0.00")
            {
                txtPeriod.Text = "";
                txtPeriod.ForeColor = Color.Black;
            }
        }
        private void TxtGrowth_Leave(object sender, EventArgs e)
        {
            if (txtGrowth.Text == "")
            {
                txtGrowth.Text = "%";
                txtGrowth.ForeColor = Color.Black;
            }
        }
        private void TxtGrowth_Enter(object sender, EventArgs e)
        {
            if (txtGrowth.Text == "0.00")
            {
                txtGrowth.Text = "";
                txtGrowth.ForeColor = Color.Black;
            }
        }
        private void TxtFees_Leave(object sender, EventArgs e)
        {
            if (txtFees.Text == "")
            {
                txtFees.Text = "%";
                txtFees.ForeColor = Color.Black;
            }
        }
        private void TxtFees_Enter(object sender, EventArgs e)
        {
            if (txtFees.Text == "0.00")
            {
                txtFees.Text = "";
                txtFees.ForeColor = Color.Black;
            }
        }
        private void btnSaving_Click(object sender, EventArgs e)
        {
            //1. read input
            bool ok = ReadInputSaving();

            //2. calculate
            if (ok)
            {
                //calculate and display results.
                CalculateAndDisplayFutureValue();
            }
            //Display the results from the calculation
            //3. show results            
        }
        
        private bool ReadInputSaving()
        {            
            bool initialBalOK = ReadInitialBalance();
            bool monthlyDepOK = ReadMonthlyDeposit();
            bool periodOK = ReadPeriod();
            bool growthOK = ReadGrowth();
            bool feesOK = ReadFees();
            
            return initialBalOK && monthlyDepOK && periodOK && growthOK && feesOK;
            
        }        
        private bool ReadInitialBalance()
        {
            double initialBal = 0.0;
            
            bool ok = double.TryParse(txtBalance.Text, out initialBal);
            if (!ok)
            {
                MessageBox.Show("Invalid value for initial deposit", "Error");                
            }            
            savingCalc.SetInitialBalance(initialBal);
            return ok;
        }
        private bool ReadMonthlyDeposit()
        {
            double monthlyDep = 0.0;
            
            bool ok = double.TryParse(txtMonthlyDep.Text, out monthlyDep);           
            if (!ok)
            {
                MessageBox.Show("Invalid value for monthly deposit", "Error");                
            }            
            savingCalc.SetMonthlyDeposit(monthlyDep);
            return ok;
        }
        private bool ReadPeriod()
        {
            double period = 0.0; 
            
            bool ok = double.TryParse(txtPeriod.Text, out period);
            if (!ok)            
            {
                MessageBox.Show("Invalid value for period", "Error");                
            }            
            savingCalc.SetPeriod(period);
            return ok;
        }
        private bool ReadGrowth()
        {
            double growth = 0.0;

            bool ok = double.TryParse(txtGrowth.Text, out growth);
            if (!ok)
            {
                MessageBox.Show("Invalid value for growth", "Error");
            }
            growth = growth / 100; //convert growth to decimal
            savingCalc.SetGrowth(growth);
            return ok;
        }
        private bool ReadFees()
        {
            double fees = 0.0;

            bool ok = double.TryParse(txtFees.Text, out fees);
            if (!ok)
            {
                MessageBox.Show("Invalid value for fees", "Error");
            }
            fees = fees / 100; //convert growth to decimal
            savingCalc.SetFees(fees);
            return ok;
        }
        private void CalculateAndDisplayFutureValue()
        {            
            txtBalance.Text = double.Parse(txtBalance.Text).ToString("N2");
            txtMonthlyDep.Text = double.Parse(txtMonthlyDep.Text).ToString("N2");
            txtPeriod.Text = double.Parse(txtPeriod.Text).ToString("N2");
            txtGrowth.Text = double.Parse(txtGrowth.Text).ToString("N2");
            txtFees.Text = double.Parse(txtFees.Text).ToString("N2");
            lblAmtPd.Text = savingCalc.CalculateAmountPaid().ToString("N2");            
            lblAmtEarned.Text = savingCalc.CalculateAmountEarned().ToString("N2");            
            lblFinBal.Text = savingCalc.CalculateFinalBalance().ToString("N2");           
            lblTotFees.Text = savingCalc.CalculateTotalFees().ToString("N2");          
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();            
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtHeightFt.Text = "";
            txtHeightIn.Text = "";
            txtWeightLbs.Text = "";

            rbtnMetric.Checked = false;            

            lblNormalBMI.Text = "";
            lblNormalWeight.Text = "";
            lblbmi.Text = "";
            lblWeightCat.Text = "";
            grpResult.Text = "Results for ";
        }

        Control ctrl;        
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                    e.Handled = e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                    e.Handled = e.SuppressKeyPress = true;
                }
                else
                return;
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            SizeF stringSize;
            using (Graphics gfx = this.CreateGraphics())
            {
                stringSize = gfx.MeasureString(tb.Text, tb.Font);
            }
            tb.Width = (int)Math.Round(stringSize.Width, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBalance.Text = "0.00";
            txtBalance.ForeColor = Color.LightGray;
            txtMonthlyDep.Text = "0.00";
            txtMonthlyDep.ForeColor = Color.LightGray;
            txtPeriod.Text = "0.00";
            txtPeriod.ForeColor = Color.LightGray;
            txtGrowth.Text = "%";
            txtGrowth.ForeColor = Color.LightGray;
            txtFees.Text = "%";
            txtFees.ForeColor = Color.LightGray;
            lblAmtPd.Text = "";
            lblAmtEarned.Text = "";
            lblFinBal.Text = "";
            lblTotFees.Text = "";
        }
    }
}


