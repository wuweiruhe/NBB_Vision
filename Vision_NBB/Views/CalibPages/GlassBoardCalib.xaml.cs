﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Vision_NBB.Model;
using Vision_NBB.Toolkit;
using Vision_NBB.Utility;
using VM.Core;

namespace Vision_NBB.Views.CalibPages
{
    /// <summary>
    /// GlassBoardCalib.xaml 的交互逻辑
    /// </summary>
    public partial class GlassBoardCalib : Window
    {
        public GlassBoardCalib()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {




            this.Close();


        }

        private void btn_SetROI_Click(object sender, RoutedEventArgs e)
        {
            var windwon = VmHelper.OpenVmControlWindow(VMTagName.治具相机标定.标定板标定1);
            if(windwon!=null)
            {
                windwon.ShowDialog();

            }
            else
            {
                MessageBox.Show("打开失败", "", MessageBoxButton.OK, MessageBoxImage.Error);

               
            }
            
        }

        private void Btn_SaveCalibFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var response2 = System.Windows.MessageBox.Show("确认保存吗 ？", "", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);


                if (response2 == MessageBoxResult.Yes)
                {
                    var fileName = CurrentInfo.Gen_Camera2_CalibFileName();


                    var isSucessfull = VmHelper.ExportBoardCalibFile(VMTagName.治具相机标定.标定板标定1, fileName);



                    if (isSucessfull)
                    {
                        MessageBox.Show("保存成功", "", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("保存失败", "", MessageBoxButton.OK, MessageBoxImage.Error);

                    }

                    return;
                }








              


                //VmHelper.ExportImageCalibFile("", fileName);


            }
            catch (Exception ex)
            {

                MessageBox.Show("保存失败", "", MessageBoxButton.OK, MessageBoxImage.Error);


            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
              var   process = VmSolution.Instance[VMTagName.治具相机标定.治具相机标定流程名] as VmProcedure;

                if (process == null)
                {
                    MessageBox.Show("加载标定流程失败", "", MessageBoxButton.OK, MessageBoxImage.Error);

                }


                this.vm.ModuleSource = process;
            }
            catch (Exception ex)
            {
                GetLogHelper.VisionLog.Error(ex);

            }
        }

        private void btn_ExecuteOnce_Click(object sender, RoutedEventArgs e)
        {      
            var process = (VmProcedure)VmSolution.Instance[VMTagName.治具相机标定.治具相机标定流程名];
            if (null == process) return;
            process.Run();
        }

        private void Btn_ImageSource_Click(object sender, RoutedEventArgs e)
        {
            var windwon = VmHelper.OpenVmControlWindow(VMTagName.治具相机标定.图像源);
            if (windwon != null)
            {
                windwon.ShowDialog();

            }
            else
            {

                MessageBox.Show("打开失败");
            }

        }
    }
}
