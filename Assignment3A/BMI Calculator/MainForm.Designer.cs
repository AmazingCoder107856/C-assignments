using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code




        #endregion
        private Label lblNormalWeight;
        private Label lblNormalBMI;
        private Button btnSaving;
        private GroupBox grpFutureVal;
        private Label lblTotFees;
        private Label lblFinBal;
        private Label lblAmtEarned;
        private Label lblAmtPd;
        private Label lblTotalFees;
        private Label lblFinalBal;
        private Label lblAmountEarned;
        private Label lblAmoutPaid;
        private Label label2;
        private TextBox txtBalance;
        public GroupBox grpUnit;
        public TextBox txtWeightLbs;
        public TextBox txtHeightIn;
        public TextBox txtHeightFt;
        public TextBox txtName;
        public RadioButton rbtnImperial;
        public RadioButton rbtnMetric;
        private ListBox listResults;
        private Button btnclear;
        public GroupBox grpBMR;
        public Button btnBMR;
        public GroupBox grpWeekly;
        public RadioButton rbtnSedentary;
        public RadioButton rbtnLight;
        public RadioButton rbtnModerate;
        public RadioButton rbtnVery;
        public RadioButton rbtnExtra;
        public TextBox txtAge;
        public Label lblAge;
        public GroupBox grpGender;
        public RadioButton rbtnMale;
        public RadioButton rbtnFemale;
        public GroupBox grpBMI;
        public Button btnOk;
        public Button btnReset;
        public Button btnExit;
    }
}
