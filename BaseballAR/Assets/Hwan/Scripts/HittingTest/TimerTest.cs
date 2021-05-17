using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    // ±×³É Á¦ »ı°¢´ë·Î ÄÚµùÇÑ°ÅÀÌ±â ¶§¹®¿¡ ¼ö¿¬´ÔÀÌ ÇÏ½Ã·Á´Â°Í°ú´Â ¾È ¸ÂÀ» ¼ö ÀÖ½À´Ï´Ù.
    // Àú¶ó¸é ±×³É ÀÌ·¸°Ô ±¸ÇöÇÏ°Ú´Ù¶ó´Â °ÍÀÌ´Ï ±×³É ÂüÁ¶¸¸ÇØÁÖ¼¼¿ä~~

    // Å¸ÀÌ¸Ó ¸ØÃâ¶§¸¶´Ù ½Ã°£ÀúÀåÇÑ °Å ³ÖÀ» ¼ö ÀÖ´Â ¸®½ºÆ®¸¦ ¸¸µì´Ï´Ù.
    List<float> PauseTimeList = new List<float>();
    
    // ¿©±â¿¡ ½Ã°£ ³ÖÀ»°Ì´Ï´Ù.
    float time;

    void Update()
    {
        // ½Ã°£Èê·¯°¡¿ä
        time = Time.time;
        
        // ÇÔ¼ö¸¦ È£ÃâÇÒ°Ì´Ï´Ù. 
        TimeStop();
        ListTime();
    }

    // ´ÔÀÌ ¸¸µç Å¸ÀÌ¸Ó ½ºÅ¾ ºñ½ÁÇÑ±â´É
    void TimeStop()
    {
        // Á¶°ÇÀº ´ÔÀÌ ¹Ù²Ù¼¼¿ä. ÀÏ´Ü TÅ° ´©¸£¸é Å¸ÀÓ ¸ØÃß´Â°ÅÀÔ´Ï´Ù.
        if (Input.GetKeyDown(KeyCode.T))
        {
            // ¸®½ºÆ®¿¡ ¸Ø­ŸÀ»¶§ Å¸ÀÓ ³Ö½À´Ï´Ù.
            PauseTimeList.Add(time);
            
            // ÄÜ¼ÖÃ¢¿¡ È®ÀÎÇÒ·Á°í ±×³É ³ÖÀº°Ì´Ï´Ù. for¹® ³ª¿Ó´Ù°í ÂÌÁö¸¶¼¼¿ä.
            for (int i = 0; i < PauseTimeList.Count; i++)
            {
                print(PauseTimeList[i]);
            }
        }
    }

    // ¸®½ºÆ®¿¡ ³Ö¾îÁØ Å¸ÀÓµé º¸¿©ÁÖ´Â ÇÔ¼öÀÔ´Ï´Ù.
    void ListTime()
    {
        // Å¸ÀÓ ¼ø¼­´ë·Î ºĞ·ùÇØÁİ´Ï´Ù. 
        PauseTimeList.Sort();

        // ¼ø¼­ ÇÁ¸°Æ® ÇØÁÙ·Á°í ¾´°Ì´Ï´Ù ¿ª½Ã ÂÌÁö¸¶¼¼¿ä.
        // RÅ° ´©¸£¸é ¼øÀ§ º¸¿©Áİ´Ï´Ù. Á¶°ÇÀº ´ÔÀÌ ¾Ë¾Æ¼­ ¹Ù²Ù¼¼¿ä 
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < PauseTimeList.Count; i++)
            {
                print("¼øÀ§ : " + PauseTimeList[i]);
            }
        }

    }
    // ´ç½ÅÀº ¶È¶ÈÇÕ´Ï´Ù. ÀÚ½Å°¨À» °¡Áö¼¼¿ä. 
}
