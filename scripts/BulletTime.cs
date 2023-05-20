using System;
using System.Drawing;
using System.Windows.Forms;
using GTA;

namespace BulletTimeCS {


   public class BulletTime : Script {


		bool bBulletTime = true;
		float bTime = 0.5F;

      public BulletTime() {


         this.KeyDown += new GTA.KeyEventHandler(this.BulletTime_KeyDown);
         this.KeyUp += new GTA.KeyEventHandler(this.BulletTime_KeyUp);


      }

         private void BulletTime_KeyDown(object sender, GTA.KeyEventArgs e) {



         if (e.Key == Keys.RButton && bBulletTime == true) 
		 {

			 Game.TimeScale = bTime;

		 }
		 
		 if (e.Key == Keys.PageUp) 
		 {

			 if (!bBulletTime)
			 {
				bBulletTime = true;
				bTime = 0.5F;
				Game.DisplayText("Bullet Time Enabled! Speed: 50%");
			 } else	{
				if (bTime == 0.5F)
				{
					bTime = 0.3F;
					Game.DisplayText("Bullet Time Speed: 30%");
				}
				else if (bTime == 0.3F)
				{
					bTime = 0.1F;
					Game.DisplayText("Bullet Time Speed: 10%");
				}
				else
				{
					bBulletTime = false;
					Game.DisplayText("Bullet Time Disabled!");
				}
			}

		 }

      }
	  
	  private void BulletTime_KeyUp(object sender, GTA.KeyEventArgs e) {



         if (e.Key == Keys.RButton) 
		 {
			 Game.TimeScale = 1.0F;
		 }

      }

	}
   }