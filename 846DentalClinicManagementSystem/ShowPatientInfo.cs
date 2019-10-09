﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace _846DentalClinicManagementSystem
{
    public partial class ShowPatientInfo : Form
    {
        public ShowPatientInfo()
        {
            InitializeComponent();
        }

        static String workingDirectory = Environment.CurrentDirectory;
        static String projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        static String LocalDbSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=";
        static String LocalDBFile = projectDirectory + @"\846DentalClinicDB.mdf";
        static String connString = LocalDbSource + LocalDBFile + ";Integrated Security=True";
        SqlConnection sqlcon = new SqlConnection(connString);


        // Inside each polygon - it determines the clickable part of the shape to change its fill color 
        Rectangle TopRectangle = new Rectangle(10, 0, 10, 10);
        Rectangle BottomRectangle = new Rectangle(10, 20, 10, 10);
        Rectangle LeftRectangle = new Rectangle(0, 10, 10, 10);
        Rectangle RightRectangle = new Rectangle(20, 10, 10, 10);

        // This is the Border Line of the teeth or the shape itself
        Rectangle InsideRectangle = new Rectangle(10, 10, 10, 10);                                  //Center Teeth
        Point[] a = { new Point(0, 0), new Point(30, 0), new Point(20, 10), new Point(10, 10) };    //Top Teeth
        Point[] b = { new Point(0, 0), new Point(0, 30), new Point(10, 20), new Point(10, 10) };    //Left Teeth
        Point[] c = { new Point(0, 30), new Point(30, 30), new Point(20, 20), new Point(10, 20) };  //Bottom Teeth
        Point[] d = { new Point(30, 30), new Point(30, 0), new Point(20, 10), new Point(20, 20) };  //Right Teeth

        // This is another border line inside the shape, this is where you color the shape
        Point[] TopPolygonFill = { new Point(1, 1), new Point(29, 1), new Point(19, 10), new Point(11, 10) };
        Point[] LeftPolygonFill = { new Point(1, 1), new Point(1, 29), new Point(10, 19), new Point(10, 11) };
        Point[] BottomPolygonFill = { new Point(0, 30), new Point(30, 30), new Point(20, 20), new Point(10, 21) };
        Point[] RightPolygonFill = { new Point(30, 30), new Point(30, 0), new Point(21, 10), new Point(21, 20) };
        Rectangle InsideRectangleFill = new Rectangle(11, 11, 9, 9);

        // Pen

        Pen p = new Pen(new SolidBrush(Color.Black));
        Pen p1 = new Pen(new SolidBrush(Color.Transparent));
        Pen p2 = new Pen(new SolidBrush(Color.Blue), 2);
        Pen p3 = new Pen(new SolidBrush(Color.Red), 2);

        //Solid Brush or Fill Color
        SolidBrush red = new SolidBrush(Color.FromArgb(239, 45, 45));
        SolidBrush white = new SolidBrush(Color.White);
        SolidBrush blue = new SolidBrush(Color.FromArgb(51, 01, 247));


        // Draw Check in the teeth
        Point[] check = { new Point(0, 18), new Point(8, 30), new Point(30, 0), new Point(8, 23) };

        //Draw X in the Teeth
        Point[] ekis1 = { new Point(3, 0), new Point(30, 27), new Point(27, 30), new Point(0, 3) };
        Point[] ekis2 = { new Point(27, 0), new Point(30, 3), new Point(3, 30), new Point(0, 27) };


        int PatientID = MainForm.c1.PatientID;

        ArrayList TeethArray = new ArrayList();

        String[] TopTeethColor = new String[32];
        String[] BottomTeethColor = new string[32];
        String[] LeftTeethColor = new String[32];
        String[] RightTeethColor = new string[32];
        String[] CenterTeethColor = new String[32];
        String[] Checked = new string[32];
        String[] ex = new string[32];

        private void ShowPatientInfo_Load(object sender, EventArgs e)
        {
            lbl_PatientName.Text = MainForm.c1.PatientName;
        }

        private void FillArrayValues()
        {
            for (int i = 0; i < 32; i++)
            {
                TopTeethColor[i] = "White";
                BottomTeethColor[i] = "White";
                LeftTeethColor[i] = "White";
                RightTeethColor[i] = "White";
                CenterTeethColor[i] = "White";
                Checked[i] = "false";
                ex[i] = "false";

            }
        }


        private void TeethPanel1_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel1);
        private void TeethPanel2_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel2);
        private void TeethPanel3_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel3);
        private void TeethPanel4_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel4);
        private void TeethPanel5_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel5);
        private void TeethPanel6_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel6);
        private void TeethPanel7_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel7);
        private void TeethPanel8_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel8);
        private void TeethPanel9_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel9);
        private void TeethPanel10_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel10);
        private void TeethPanel11_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel11);
        private void TeethPanel12_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel12);
        private void TeethPanel13_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel13);
        private void TeethPanel14_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel14);
        private void TeethPanel15_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel15);
        private void TeethPanel16_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel16);
        private void TeethPanel17_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel17);
        private void TeethPanel18_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel18);
        private void TeethPanel19_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel19);
        private void TeethPanel20_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel20);
        private void TeethPanel21_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel21);
        private void TeethPanel22_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel22);
        private void TeethPanel23_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel23);
        private void TeethPanel24_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel24);
        private void TeethPanel25_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel25);
        private void TeethPanel26_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel26);
        private void TeethPanel27_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel27);
        private void TeethPanel28_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel28);
        private void TeethPanel29_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel29);
        private void TeethPanel30_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel30);
        private void TeethPanel31_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel31);
        private void TeethPanel32_Paint(object sender, PaintEventArgs e) => DrawTeeth(TeethPanel32);

        private void DrawTeeth(Panel TeethPanel)
        {

            Graphics gs = TeethPanel.CreateGraphics();
            gs.DrawRectangle(p, InsideRectangle);
            gs.DrawRectangle(p1, InsideRectangleFill);

            gs.DrawPolygon(p, a);
            gs.DrawPolygon(p, b);
            gs.DrawPolygon(p, c);
            gs.DrawPolygon(p, d);

            gs.DrawPolygon(p1, TopPolygonFill);
            gs.DrawPolygon(p1, LeftPolygonFill);
            gs.DrawPolygon(p1, BottomPolygonFill);
            gs.DrawPolygon(p1, RightPolygonFill);

        }

        // Function to fill teeth by parts
        private void FillTeeth(Panel TeethPanel, MouseEventArgs e, object teethLetter, int index)
        {

            Graphics gs = TeethPanel.CreateGraphics();
            switch (teethLetter)
            {
                case MouseButtons.Left:

                    if (Checked[index] == "false" && ex[index] == "false")
                    {
                        if (this.TopRectangle.Contains(e.Location))
                        {

                            if (TopTeethColor[index] == "White")
                            {
                                gs.FillPolygon(red, TopPolygonFill);
                                TopTeethColor[index] = "Red";
                            }
                            else if (TopTeethColor[index] == "Red")
                            {
                                gs.FillPolygon(blue, TopPolygonFill);
                                TopTeethColor[index] = "Blue";
                            }
                            else if (TopTeethColor[index] == "Blue")
                            {
                                gs.FillPolygon(white, TopPolygonFill);
                                TopTeethColor[index] = "White";
                            }
                        }
                        else if (this.BottomRectangle.Contains(e.Location))
                        {

                            if (BottomTeethColor[index] == "White")
                            {
                                gs.FillPolygon(red, BottomPolygonFill);
                                BottomTeethColor[index] = "Red";
                            }
                            else if (BottomTeethColor[index] == "Red")
                            {
                                gs.FillPolygon(blue, BottomPolygonFill);
                                BottomTeethColor[index] = "Blue";
                            }
                            else if (BottomTeethColor[index] == "Blue")
                            {
                                gs.FillPolygon(white, BottomPolygonFill);
                                BottomTeethColor[index] = "White";
                            }

                        }
                        else if (this.LeftRectangle.Contains(e.Location))
                        {
                            if (LeftTeethColor[index] == "White")
                            {
                                gs.FillPolygon(red, LeftPolygonFill);
                                LeftTeethColor[index] = "Red";
                            }
                            else if (LeftTeethColor[index] == "Red")
                            {
                                gs.FillPolygon(blue, LeftPolygonFill);
                                LeftTeethColor[index] = "Blue";
                            }
                            else if (LeftTeethColor[index] == "Blue")
                            {
                                gs.FillPolygon(white, LeftPolygonFill);
                                LeftTeethColor[index] = "White";
                            }

                        }
                        else if (this.RightRectangle.Contains(e.Location))
                        {

                            if (RightTeethColor[index] == "White")
                            {
                                gs.FillPolygon(red, RightPolygonFill);
                                RightTeethColor[index] = "Red";
                            }
                            else if (RightTeethColor[index] == "Red")
                            {
                                gs.FillPolygon(blue, RightPolygonFill);
                                RightTeethColor[index] = "Blue";
                            }
                            else if (RightTeethColor[index] == "Blue")
                            {
                                gs.FillPolygon(white, RightPolygonFill);
                                RightTeethColor[index] = "White";
                            }

                        }
                        else if (this.InsideRectangle.Contains(e.Location))
                        {
                            if (CenterTeethColor[index] == "White")
                            {
                                gs.FillRectangle(red, InsideRectangleFill);
                                CenterTeethColor[index] = "Red";
                            }
                            else if (CenterTeethColor[index] == "Red")
                            {
                                gs.FillRectangle(blue, InsideRectangleFill);
                                CenterTeethColor[index] = "Blue";
                            }
                            else if (CenterTeethColor[index] == "Blue")
                            {
                                gs.FillRectangle(white, InsideRectangleFill);
                                CenterTeethColor[index] = "White";
                            }

                        }
                    }

                    break;
                case MouseButtons.Right:

                    TopTeethColor[index] = "White";
                    BottomTeethColor[index] = "White";
                    LeftTeethColor[index] = "White";
                    RightTeethColor[index] = "White";
                    CenterTeethColor[index] = "White";

                    if (Checked[index] == "false" && ex[index] == "false")
                    {

                        TeethPanel.Invalidate();
                        TeethPanel.Update();
                        gs.DrawPolygon(p2, check);
                        gs.FillPolygon(blue, check);
                        Checked[index] = "true";

                    }
                    else if (Checked[index] == "true" && ex[index] == "false")
                    {

                        TeethPanel.Invalidate();
                        TeethPanel.Update();
                        gs.DrawPolygon(p3, ekis1);
                        gs.DrawPolygon(p3, ekis2);
                        gs.FillPolygon(red, ekis1);
                        gs.FillPolygon(red, ekis2);
                        ex[index] = "true";
                        Checked[index] = "false";

                    }
                    else if (Checked[index] == "false" && ex[index] == "true")
                    {

                        TeethPanel.Invalidate();
                        TeethPanel.Update();
                        TeethPanel.Refresh();
                        ex[index] = "false";
                    }


                    break;
            }
            if (!(TeethArray.Contains(index)))
            {
                TeethArray.Add(index);
            }
        }
        // Mouse Click event to call FillTeeth Function
        private void TeethPanel1_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel1, e, e.Button, 0);
        private void TeethPanel2_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel2, e, e.Button, 1);
        private void TeethPanel3_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel3, e, e.Button, 2);
        private void TeethPanel4_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel4, e, e.Button, 3);
        private void TeethPanel5_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel5, e, e.Button, 4);
        private void TeethPanel6_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel6, e, e.Button, 5);
        private void TeethPanel7_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel7, e, e.Button, 6);
        private void TeethPanel8_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel8, e, e.Button, 7);
        private void TeethPanel9_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel9, e, e.Button, 8);
        private void TeethPanel10_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel10, e, e.Button, 9);
        private void TeethPanel11_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel11, e, e.Button, 10);
        private void TeethPanel12_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel12, e, e.Button, 11);
        private void TeethPanel13_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel13, e, e.Button, 12);
        private void TeethPanel14_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel14, e, e.Button, 13);
        private void TeethPanel15_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel15, e, e.Button, 14);
        private void TeethPanel16_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel16, e, e.Button, 15);
        private void TeethPanel17_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel17, e, e.Button, 16);
        private void TeethPanel18_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel18, e, e.Button, 17);
        private void TeethPanel19_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel19, e, e.Button, 18);
        private void TeethPanel20_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel20, e, e.Button, 19);
        private void TeethPanel21_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel21, e, e.Button, 20);
        private void TeethPanel22_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel22, e, e.Button, 21);
        private void TeethPanel23_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel23, e, e.Button, 22);
        private void TeethPanel24_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel24, e, e.Button, 23);
        private void TeethPanel25_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel25, e, e.Button, 24);
        private void TeethPanel26_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel26, e, e.Button, 25);
        private void TeethPanel27_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel27, e, e.Button, 26);
        private void TeethPanel28_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel28, e, e.Button, 27);
        private void TeethPanel29_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel29, e, e.Button, 28);
        private void TeethPanel30_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel30, e, e.Button, 29);
        private void TeethPanel31_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel31, e, e.Button, 30);
        private void TeethPanel32_MouseClick(object sender, MouseEventArgs e) => FillTeeth(TeethPanel32, e, e.Button, 31);



        private Panel PanelNumber(int teethNumber)
        {
            // Console.WriteLine(teethNumber);
            switch (teethNumber)
            {
                case 0: return TeethPanel1;
                case 1: return TeethPanel2;
                case 2: return TeethPanel3;
                case 3: return TeethPanel4;
                case 4: return TeethPanel5;
                case 5: return TeethPanel6;
                case 6: return TeethPanel7;
                case 7: return TeethPanel8;
                case 8: return TeethPanel9;
                case 9: return TeethPanel10;
                case 10: return TeethPanel11;
                case 11: return TeethPanel12;
                case 12: return TeethPanel13;
                case 13: return TeethPanel14;
                case 14: return TeethPanel15;
                case 15: return TeethPanel16;
                case 16: return TeethPanel17;
                case 17: return TeethPanel18;
                case 18: return TeethPanel19;
                case 19: return TeethPanel20;
                case 20: return TeethPanel21;
                case 21: return TeethPanel22;
                case 22: return TeethPanel23;
                case 23: return TeethPanel24;
                case 24: return TeethPanel25;
                case 25: return TeethPanel26;
                case 26: return TeethPanel27;
                case 27: return TeethPanel28;
                case 28: return TeethPanel29;
                case 29: return TeethPanel30;
                case 30: return TeethPanel31;
                case 31: return TeethPanel32;

            }

            return null;

        }

        private void insertTeethStatus(int TeethNum)
        {
            int TeethIDCount = 0;
            SqlCommand cmd = new SqlCommand(
                "Insert Into Teeth (TeethNumber,TeethTop,TeethBottom,TeethRight,TeethLeft,TeethCenter,TeethCheck,TeethCross) " +
                "Values(@TeethNum,@Top,@Bottom,@Right,@Left,@Center,@Check,@Cross) ", sqlcon);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TeethNum", TeethNum);
            cmd.Parameters.AddWithValue("@Top", TopTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Bottom", BottomTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Right", RightTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Left", LeftTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Center", CenterTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Check", Checked[TeethNum]);
            cmd.Parameters.AddWithValue("@Cross", ex[TeethNum]);

            SqlCommand cmd2 = new SqlCommand(
                " SELECT TOP 1 * FROM [Teeth] ORDER BY TeethID DESC", sqlcon);


            sqlcon.Open();
            try
            {
                cmd.ExecuteNonQuery();
                TeethIDCount = Convert.ToInt32(cmd2.ExecuteScalar());
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            sqlcon.Close();
            // Console.WriteLine(TeethIDCount);
            InsertPatientTeeth(TeethIDCount);

        }

        private void InsertPatientTeeth(int TeethID_fk)
        {
           
            SqlCommand cmd = new SqlCommand(
                "Insert Into [PatientTeeth] (PatientID_fk,TeethID_fk) " +
                "Values(@PatientID_fk,@TeethID_fk) ", sqlcon);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@PatientID_fk", PatientID);
            cmd.Parameters.AddWithValue("@TeethID_fk", TeethID_fk);

            sqlcon.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            sqlcon.Close();
        }

        /* Will Check on the database to see if the patient has already 
         * an entry of teeth number 
          */
        private int CheckPatientTeethEntry(int teethNum)
        {
            int ret = 0;
            //SqlCommand cmd = new SqlCommand(
            //    "SELECT CASE WHEN EXISTS ( SELECT Teethnumber FROM Teeth INNER JOIN [Patient-Teeth] " +
            //    "ON TeethID = TeethID_fk WHERE PatientID_fk = @patientID AND TeethNumber = @teethnum) " +
            //    "THEN CAST (1 AS BIT) ELSE CAST(0 AS BIT) END " ,sqlcon);
            SqlCommand cmd = new SqlCommand(
                "SELECT TeethID FROM Teeth " +
                "INNER JOIN[Patient-Teeth] ON TeethID = TeethID_fk " +
                "WHERE PatientID_fk = @patientID AND TeethNumber = @teethnum", sqlcon);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@patientID", PatientID);
            cmd.Parameters.AddWithValue("@teethnum", teethNum);

            sqlcon.Open();
            try
            {
                ret = (Convert.ToInt32(cmd.ExecuteScalar()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            sqlcon.Close();
            return ret;

        }

        private void UpdatePatientTeeth(int TeethID, int TeethNum)
        {
            SqlConnection sqlcon = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(
                "UPDATE [Teeth] SET TeethTop = @Top, TeethBottom = @Bottom, TeethRight = @Right, " +
                "TeethLeft = @Left, TeethCenter = Center, TeethCheck = @Check, TeethCross = @Cross " +
                "WHERE TeethID = @TeethID", sqlcon);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Top", TopTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Bottom", BottomTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Right", RightTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Left", LeftTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Center", CenterTeethColor[TeethNum]);
            cmd.Parameters.AddWithValue("@Check", Checked[TeethNum]);
            cmd.Parameters.AddWithValue("@Cross", ex[TeethNum]);
            cmd.Parameters.AddWithValue("@TeethID", TeethID);


            sqlcon.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            sqlcon.Close();
        }

 
        private void RetrievePatientTeethStatus()
        {
            int teethNumber = 0;
            String teethTop = "White", teethBottom = "White", teethLeft = "White", teethRight = "White";
            String teethCenter = "White", teethCheck = "false", teethEx = "false";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(
                    "SELECT TeethNumber, TeethTop, TeethBottom, TeethRight," +
                    "TeethLeft,TeethCenter, TeethCheck, TeethCross " +
                    "FROM Teeth INNER JOIN [PatientTeeth] " +
                    "ON TeethID = TeethID_fk " +
                    "WHERE PatientID_fk = @PatientID", sqlcon);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@PatientID", PatientID);
            adapter.SelectCommand = cmd;

            try
            {
                adapter.Fill(dt);
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
           

            for (int i = 0; i < dt.Rows.Count; i++)
            {


                teethNumber = Convert.ToInt32(dt.Rows[i][0]);
                teethTop = dt.Rows[i][1].ToString();
                teethBottom = dt.Rows[i][2].ToString();
                teethLeft = dt.Rows[i][3].ToString();
                teethRight = dt.Rows[i][4].ToString();
                teethCenter = dt.Rows[i][5].ToString();
                teethCheck = dt.Rows[i][6].ToString();
                teethEx = dt.Rows[i][7].ToString();


                Panel teethNumberPanel = new Panel();
                teethNumberPanel = PanelNumber(teethNumber);
                Graphics gs = teethNumberPanel.CreateGraphics();


                if (teethTop == "Red")
                {
                    gs.FillPolygon(red, TopPolygonFill);

                }
                else if (teethTop == "Blue")
                {
                    gs.FillPolygon(blue, TopPolygonFill);
                }

                if (teethBottom == "Red")
                {
                    gs.FillPolygon(red, BottomPolygonFill);
                }
                else if (teethBottom == "Blue")
                {
                    gs.FillPolygon(blue, BottomPolygonFill);
                }

                if (teethLeft == "Red")
                {
                    gs.FillPolygon(red, LeftPolygonFill);
                }

                else if (teethLeft == "Blue")
                {
                    gs.FillPolygon(blue, LeftPolygonFill);
                }
                if (teethRight == "Red")
                {
                    gs.FillPolygon(red, RightPolygonFill);
                }
                else if (teethRight == "Blue")
                {
                    gs.FillPolygon(blue, RightPolygonFill);
                }
                if (teethCenter == "Red")
                {
                    gs.FillRectangle(red, InsideRectangleFill);
                }
                else if (teethCenter == "Blue")
                {
                    gs.FillRectangle(blue, InsideRectangleFill);
                }


                if (teethCheck == "true")
                {
                    gs.DrawPolygon(p2, check);
                    gs.FillPolygon(blue, check);

                }
                if (teethEx == "true")
                {
                    gs.DrawPolygon(p3, ekis1);
                    gs.DrawPolygon(p3, ekis2);
                    gs.FillPolygon(red, ekis1);
                    gs.FillPolygon(red, ekis2);
                }



            }
        }

     
        private void btn_closePatientInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tab_Charting_Click(object sender, EventArgs e)
        {
            FillArrayValues();
            RetrievePatientTeethStatus();
        }



        private void EnableTeethPanel()
        {
            TeethPanel1.Enabled = true;
            TeethPanel2.Enabled = true;
            TeethPanel3.Enabled = true;
            TeethPanel4.Enabled = true;
            TeethPanel5.Enabled = true;
            TeethPanel6.Enabled = true;
            TeethPanel7.Enabled = true;
            TeethPanel8.Enabled = true;
            TeethPanel9.Enabled = true;
            TeethPanel10.Enabled = true;
            TeethPanel11.Enabled = true;
            TeethPanel12.Enabled = true;
            TeethPanel13.Enabled = true;
            TeethPanel14.Enabled = true;
            TeethPanel15.Enabled = true;
            TeethPanel16.Enabled = true;
            TeethPanel17.Enabled = true;
            TeethPanel18.Enabled = true;
            TeethPanel19.Enabled = true;
            TeethPanel20.Enabled = true;
            TeethPanel21.Enabled = true;
            TeethPanel22.Enabled = true;
            TeethPanel23.Enabled = true;
            TeethPanel24.Enabled = true;
            TeethPanel25.Enabled = true;
            TeethPanel26.Enabled = true;
            TeethPanel27.Enabled = true;
            TeethPanel28.Enabled = true;
            TeethPanel29.Enabled = true;
            TeethPanel30.Enabled = true;
            TeethPanel31.Enabled = true;
            TeethPanel32.Enabled = true;
            
        }

        private void DisableTeethPanel()
        {
            TeethPanel1.Enabled = false;
            TeethPanel2.Enabled = false;
            TeethPanel3.Enabled = false;
            TeethPanel4.Enabled = false;
            TeethPanel5.Enabled = false;
            TeethPanel6.Enabled = false;
            TeethPanel7.Enabled = false;
            TeethPanel8.Enabled = false;
            TeethPanel9.Enabled = false;
            TeethPanel10.Enabled = false;
            TeethPanel11.Enabled = false;
            TeethPanel12.Enabled = false;
            TeethPanel13.Enabled = false;
            TeethPanel14.Enabled = false;
            TeethPanel15.Enabled = false;
            TeethPanel16.Enabled = false;
            TeethPanel17.Enabled = false;
            TeethPanel18.Enabled = false;
            TeethPanel19.Enabled = false;
            TeethPanel20.Enabled = false;
            TeethPanel21.Enabled = false;
            TeethPanel22.Enabled = false;
            TeethPanel23.Enabled = false;
            TeethPanel24.Enabled = false;
            TeethPanel25.Enabled = false;
            TeethPanel26.Enabled = false;
            TeethPanel27.Enabled = false;
            TeethPanel28.Enabled = false;
            TeethPanel29.Enabled = false;
            TeethPanel30.Enabled = false;
            TeethPanel31.Enabled = false;
            TeethPanel32.Enabled = false;
        }

      
        private void btn_SaveChart_Click(object sender, EventArgs e)
        {
            int teethID = 0;
            foreach (int teeth in TeethArray)
            {
                teethID = CheckPatientTeethEntry(teeth);
                if (teethID != 0)
                {
                    // means there is an existing status sa teethnumber ng patient
                    //so imbis na insert update lang to prevent data replication

                    UpdatePatientTeeth(teethID, teeth);
                    MessageBox.Show("Save Successfully");
                    //Console.WriteLine(Convert.ToInt32(cmd.ExecuteScalar()));
                }
                else
                {
                    // means wala pang existing  status sa teethnumber ng patient
                    // so mag iinsert ng bago
                    insertTeethStatus(teeth);
                    MessageBox.Show("Save Successfully");
                    //Console.WriteLine(Convert.ToInt32(cmd.ExecuteScalar()));
                }
            }

            TeethArray.Clear(); // empty arraylist
        }

        private void btn_RefreshChart_Click(object sender, EventArgs e)
        {
            DisableTeethPanel();
            EnableTeethPanel();
            RetrievePatientTeethStatus();
            TeethArray.Clear();
        }
    }
}