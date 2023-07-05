using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManage : MonoBehaviour
{
    public GameObject caidan;
    public GameObject MainCamera;
    public GameObject GameCamera;

    //角
    public GameObject jiao;
    public GameObject djButton;
    public GameObject dj;
    public GameObject zjButton;
    public GameObject zj;
    public GameObject rjButton;
    public GameObject rj;
    public GameObject JHD;
    public void openjiao()
    {
        caidan.SetActive(false);
        jiao.SetActive(true);
        zj.SetActive(false);
        zjButton.SetActive(true);
        dj.SetActive(false);
        djButton.SetActive(true);
        rj.SetActive(false);
        rjButton.SetActive(true);
        JHD.SetActive(false);
        ButtonJiao.SetActive(false);
        BackGround.SetActive(true);
    }
    void closejiao()
    {
        caidan.SetActive(true);
        jiao.SetActive(false);
    }
    public void OpenJJX()
    {
        jiao.SetActive(false);
        ButtonJiao.SetActive(true);
    }
    public void Creatdj()
    {
        dj.SetActive(true);
        djButton.SetActive(false);
        zj.SetActive(false);
        zjButton.SetActive(true);
        rj.SetActive(false);
        rjButton.SetActive(true);
    }
    public void Creatrj()
    {
        rj.SetActive(true);
        rjButton.SetActive(false);
        zj.SetActive(false);
        zjButton.SetActive(true);
        dj.SetActive(false);
        djButton.SetActive(true);
    }
    public void Creatzj()
    {
        zj.SetActive(true);
        zjButton.SetActive(false);
        dj.SetActive(false);
        djButton.SetActive(true);
        rj.SetActive(false);
        rjButton.SetActive(true);
    }
    public void OpenJHD()
    {
        jiao.SetActive(false);
        JHD.SetActive(true);
        BackGround.SetActive(false);
    }

    //位置
    public GameObject weizhi;
    public GameObject D1;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;
    public GameObject weizhiHD;
    void openweizhi()
    {
        caidan.SetActive(false);
        weizhi.SetActive(true);
        weizhiHD.SetActive(false);
        MainCamera.SetActive(true);
        GameCamera.SetActive(false);
        D1.SetActive(false);
        D2.SetActive(false);
        D3.SetActive(false);
        D4.SetActive(false);
    }
    void closeweizhi()
    {
        caidan.SetActive(true);
        weizhi.SetActive(false);
    }
    public void openweizhiHD()
    {
        MainCamera.SetActive(false);
        GameCamera.SetActive(true);
        D1.SetActive(true);
        D2.SetActive(false);
        D3.SetActive(false);
        weizhi.SetActive(false);
        weizhiHD.SetActive(true);
    }

    //梯形
    public GameObject tixing;
    public GameObject TXButton;
    public GameObject TX;
    public GameObject DYTXButton;
    public GameObject DYTX;
    public GameObject TXHD;
    public void opentixing()
    {
        caidan.SetActive(false);
        tixing.SetActive(true);
        DYTX.SetActive(false);
        DYTXButton.SetActive(true);
        TX.SetActive(false);
        TXButton.SetActive(true);
        TXHD.SetActive(false);
        BackGround.SetActive(true);
    }
    void closetixing()
    {
        caidan.SetActive(true);
        tixing.SetActive(false);
    }
    public void OpenTXHD()
    {
        tixing.SetActive(false);
        TXHD.SetActive(true);
        BackGround.SetActive(false);
    }
    public void CreatTX()
    {
        TX.SetActive(true);
        TXButton.SetActive(false);
        DYTX.SetActive(false);
        DYTXButton.SetActive(true);
    }
    public void CreatDYTX()
    {
        DYTX.SetActive(true);
        DYTXButton.SetActive(false);
        TX.SetActive(false);
        TXButton.SetActive(true);
    }

    //三角形
    public GameObject sanjiao;
    public GameObject DYButton;
    public GameObject DY;
    public GameObject ZJButton;
    public GameObject ZJ;
    public GameObject DBButton;
    public GameObject DB;
    public GameObject SJHD;
    void opensanjiao()
    {
        caidan.SetActive(false);
        sanjiao.SetActive(true);
        DB.SetActive(false);
        DY.SetActive(false);
        ZJ.SetActive(false);
        DBButton.SetActive(true);
        DYButton.SetActive(true);
        ZJButton.SetActive(true);
        SJHD.SetActive(false);
        ButtonSanJiao.SetActive(false);
        BackGround.SetActive(true);
    }
    void closesanjiao()
    {
        caidan.SetActive(true);
        sanjiao.SetActive(false);
    }
    public void CreatDY()
    {
        DY.SetActive(true);
        DYButton.SetActive(false);
        DB.SetActive(false);
        DBButton.SetActive(true);
        ZJ.SetActive(false);
        ZJButton.SetActive(true);
    }
    public void CreatDB()
    {
        DB.SetActive(true);
        DBButton.SetActive(false);
        DY.SetActive(false);
        DYButton.SetActive(true);
        ZJ.SetActive(false);
        ZJButton.SetActive(true);
    }
    public void CreatZJ()
    {
        ZJ.SetActive(true);
        ZJButton.SetActive(false);
        DB.SetActive(false);
        DBButton.SetActive(true);
        DY.SetActive(false);
        DYButton.SetActive(true);
    }
    public void OpenSJHD()
    {
        sanjiao.SetActive(false);
        SJHD.SetActive(true);
        BackGround.SetActive(false);
    }
    public void OpenSJJX()
    {
        sanjiao.SetActive(false);
        ButtonSanJiao.SetActive(true);
    }


    //平行四边形
    public GameObject pingxing;
    public GameObject JXButton;
    public GameObject JX;
    public GameObject ZFXButton;
    public GameObject ZFX;
    public GameObject LXButton;
    public GameObject LX;
    public GameObject PXHD;
    void openpingxing()
    {
        caidan.SetActive(false);
        pingxing.SetActive(true);
        ButtonPingXing.SetActive(false);
        ZFX.SetActive(false);
        ZFXButton.SetActive(true);
        JX.SetActive(false);
        JXButton.SetActive(true);
        LX.SetActive(false);
        LXButton.SetActive(true);
        PXHD.SetActive(false);
        BackGround.SetActive(true);
    }
    void closepingxing()
    {
        caidan.SetActive(true);
        pingxing.SetActive(false);

    }
    public void OpenPXJX()
    {
        pingxing.SetActive(false);
        ButtonPingXing.SetActive(true);
    }
    public void CreatZFX()
    {
        ZFX.SetActive(true);
        ZFXButton.SetActive(false);
        LX.SetActive(false);
        LXButton.SetActive(true);
        JX.SetActive(false);
        JXButton.SetActive(true);
    }
    public void CreatLX()
    {
        LX.SetActive(true);
        LXButton.SetActive(false);
        JX.SetActive(false);
        JXButton.SetActive(true);
        ZFX.SetActive(false);
        ZFXButton.SetActive(true);
    }
    public void CreatJX()
    {
        JX.SetActive(true);
        JXButton.SetActive(false);
        ZFX.SetActive(false);
        ZFXButton.SetActive(true);
        LX.SetActive(false);
        LXButton.SetActive(true);
    }
    public void OpenPXHD()
    {
        PXHD.SetActive(true);
        pingxing.SetActive(false);
        BackGround.SetActive(false);
    }


    //平行与垂直（直线）
    public GameObject zhixian;
    public GameObject PINGXINGHUDONG;
    public GameObject CHUIXIAN;
    public GameObject CHUIXIANButton;
    public GameObject PINGXINGXIAN;
    public GameObject PINGXINGXIANButton;
    void openzhixian()
    {
        caidan.SetActive(false);
        zhixian.SetActive(true);
        PINGXINGHUDONG.SetActive(false);
        CHUIXIAN.SetActive(false);
        PINGXINGXIAN.SetActive(false);
        CHUIXIANButton.SetActive(true);
        PINGXINGXIANButton.SetActive(true);
        ButtonXian.SetActive(false);
        BackGround.SetActive(true);
    }
    void closezhixian()
    {
        caidan.SetActive(true);
        zhixian.SetActive(false);
    }
    public void OpenPINGXINGHUDONG()
    {
        PINGXINGHUDONG.SetActive(true);
        zhixian.SetActive(false);
        BackGround.SetActive(false);
    }
    public void CreatCHUIXIAN()
    {
        CHUIXIAN.SetActive(true);
        CHUIXIANButton.SetActive(false);
        PINGXINGXIAN.SetActive(false);
        PINGXINGXIANButton.SetActive(true);
    }
    public void CreatPINGXINGXIAN()
    {
        PINGXINGXIAN.SetActive(true);
        PINGXINGXIANButton.SetActive(false);
        CHUIXIAN.SetActive(false);
        CHUIXIANButton.SetActive(true);
    }
    public void OpenXJX()
    {
        ButtonXian.SetActive(true);
        zhixian.SetActive(false);
    }

    //视频
    public GameObject P16;
    public GameObject P20;
    public GameObject P21;
    public GameObject P22;
    public GameObject P23;
    public GameObject P27;
    public GameObject P28;
    public GameObject P30;
    public GameObject P31;
    public GameObject P17;
    public GameObject P18;
    public GameObject P19;
    public GameObject ButtonXian;
    public GameObject ButtonJiao;
    public GameObject ButtonPingXing;
    public GameObject ButtonSanJiao;
    public GameObject BackGround;
    public void OpenVideo(int i)
    {
        switch (i)
        {
            case 16:
                BackGround.SetActive(false);
                ButtonXian.SetActive(false);
                P16.SetActive(true);
                break;
            case 27:
                BackGround.SetActive(false);
                ButtonXian.SetActive(false);
                P27.SetActive(true);
                break;
            case 28:
                BackGround.SetActive(false);
                ButtonXian.SetActive(false);
                P28.SetActive(true);
                break;

            case 30:
                BackGround.SetActive(false);
                ButtonPingXing.SetActive(false);
                P30.SetActive(true);
                break;
            case 31:
                BackGround.SetActive(false);
                ButtonPingXing.SetActive(false);
                P31.SetActive(true);
                break;

            case 20:
                BackGround.SetActive(false);
                ButtonSanJiao.SetActive(false);
                P20.SetActive(true);
                break;
            case 21:
                BackGround.SetActive(false);
                ButtonSanJiao.SetActive(false);
                P21.SetActive(true);
                break;
            case 22:
                BackGround.SetActive(false);
                ButtonSanJiao.SetActive(false);
                P22.SetActive(true);
                break;
            case 23:
                BackGround.SetActive(false);
                ButtonSanJiao.SetActive(false);
                P23.SetActive(true);
                break;

            case 17:
                BackGround.SetActive(false);
                ButtonJiao.SetActive(false);
                P17.SetActive(true);
                break;
            case 18:
                BackGround.SetActive(false);
                ButtonJiao.SetActive(false);
                P18.SetActive(true);
                break;
            case 19:
                BackGround.SetActive(false);
                ButtonJiao.SetActive(false);
                P19.SetActive(true);
                break;
        }
    }
    public void CloseVideo(int i)
    {
        switch (i)
        {
            case 1:
                ButtonSanJiao.SetActive(true);
                break;
            case 2:
                ButtonXian.SetActive(true);
                break;
            case 3:
                ButtonPingXing.SetActive(true);
                break;
            case 4:
                ButtonJiao.SetActive(true);
                break;
        }
        P16.SetActive(false);
        P17.SetActive(false);
        P18.SetActive(false);
        P19.SetActive(false);
        P20.SetActive(false);
        P21.SetActive(false);
        P22.SetActive(false);
        P23.SetActive(false);
        P27.SetActive(false);
        P28.SetActive(false);
        P30.SetActive(false);
        P31.SetActive(false);
        BackGround.SetActive(true);
    }
}
