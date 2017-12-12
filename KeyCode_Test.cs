# 2017-12-00-
2017-12-00에 만든 유니티 게임 프로젝트입니다.

using UnityEngine;
using System.Collections;

public class KeyCode_Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void KeyCode_AtoZ()
    {   //KeyCode.A~Z: A~Z키를 나타낸다.
        if (Input.GetKeyDown(KeyCode.A)) Debug.Log(KeyCode.A);
        else if (Input.GetKeyDown(KeyCode.B)) Debug.Log(KeyCode.B);
        else if (Input.GetKeyDown(KeyCode.C)) Debug.Log(KeyCode.C);
        else if (Input.GetKeyDown(KeyCode.D)) Debug.Log(KeyCode.D);
        else if (Input.GetKeyDown(KeyCode.E)) Debug.Log(KeyCode.E);
        else if (Input.GetKeyDown(KeyCode.F)) Debug.Log(KeyCode.F);
        else if (Input.GetKeyDown(KeyCode.G)) Debug.Log(KeyCode.G);
        else if (Input.GetKeyDown(KeyCode.H)) Debug.Log(KeyCode.H);
        else if (Input.GetKeyDown(KeyCode.I)) Debug.Log(KeyCode.I);
        else if (Input.GetKeyDown(KeyCode.J)) Debug.Log(KeyCode.J);
        else if (Input.GetKeyDown(KeyCode.K)) Debug.Log(KeyCode.K);
        else if (Input.GetKeyDown(KeyCode.L)) Debug.Log(KeyCode.L);
        else if (Input.GetKeyDown(KeyCode.M)) Debug.Log(KeyCode.M);
        else if (Input.GetKeyDown(KeyCode.N)) Debug.Log(KeyCode.N);
        else if (Input.GetKeyDown(KeyCode.O)) Debug.Log(KeyCode.O);
        else if (Input.GetKeyDown(KeyCode.P)) Debug.Log(KeyCode.P);
        else if (Input.GetKeyDown(KeyCode.Q)) Debug.Log(KeyCode.Q);
        else if (Input.GetKeyDown(KeyCode.R)) Debug.Log(KeyCode.R);
        else if (Input.GetKeyDown(KeyCode.S)) Debug.Log(KeyCode.S);
        else if (Input.GetKeyDown(KeyCode.T)) Debug.Log(KeyCode.T);
        else if (Input.GetKeyDown(KeyCode.U)) Debug.Log(KeyCode.U);
        else if (Input.GetKeyDown(KeyCode.V)) Debug.Log(KeyCode.V);
        else if (Input.GetKeyDown(KeyCode.W)) Debug.Log(KeyCode.W);
        else if (Input.GetKeyDown(KeyCode.X)) Debug.Log(KeyCode.X);
        else if (Input.GetKeyDown(KeyCode.Y)) Debug.Log(KeyCode.Y);
        else if (Input.GetKeyDown(KeyCode.Z)) Debug.Log(KeyCode.Z);
    }
    void KeyCode_Keypad()
    {
        //KeyCode.Keypad0~9: 키패드키 0~9,[.][/][*][-][+][Enter]를 나타낸다.
        if (Input.GetKeyDown(KeyCode.Keypad0)) Debug.Log(KeyCode.Keypad0);
        if (Input.GetKeyDown(KeyCode.Keypad1)) Debug.Log(KeyCode.Keypad1);
        if (Input.GetKeyDown(KeyCode.Keypad2)) Debug.Log(KeyCode.Keypad2);
        if (Input.GetKeyDown(KeyCode.Keypad3)) Debug.Log(KeyCode.Keypad3);
        if (Input.GetKeyDown(KeyCode.Keypad4)) Debug.Log(KeyCode.Keypad4);
        if (Input.GetKeyDown(KeyCode.Keypad5)) Debug.Log(KeyCode.Keypad5);
        if (Input.GetKeyDown(KeyCode.Keypad6)) Debug.Log(KeyCode.Keypad6);
        if (Input.GetKeyDown(KeyCode.Keypad7)) Debug.Log(KeyCode.Keypad7);
        if (Input.GetKeyDown(KeyCode.Keypad8)) Debug.Log(KeyCode.Keypad8);
        if (Input.GetKeyDown(KeyCode.Keypad9)) Debug.Log(KeyCode.Keypad9);
        if (Input.GetKeyDown(KeyCode.KeypadPeriod)) Debug.Log(KeyCode.KeypadPeriod);
        if (Input.GetKeyDown(KeyCode.KeypadDivide)) Debug.Log(KeyCode.KeypadDivide);
        if (Input.GetKeyDown(KeyCode.KeypadMultiply)) Debug.Log(KeyCode.KeypadMultiply);
        if (Input.GetKeyDown(KeyCode.KeypadMinus)) Debug.Log(KeyCode.KeypadMinus);
        if (Input.GetKeyDown(KeyCode.KeypadPlus)) Debug.Log(KeyCode.KeypadPlus);
        if (Input.GetKeyDown(KeyCode.KeypadEnter)) Debug.Log(KeyCode.KeypadEnter);
        if (Input.GetKeyDown(KeyCode.KeypadEquals)) Debug.Log(KeyCode.KeypadEquals);    //노트북에 해당 키가 없다.
    }
    void KeyCode_Arrow()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) Debug.Log(KeyCode.UpArrow);
        if (Input.GetKeyDown(KeyCode.DownArrow)) Debug.Log(KeyCode.DownArrow);
        if (Input.GetKeyDown(KeyCode.RightArrow)) Debug.Log(KeyCode.RightArrow);
        if (Input.GetKeyDown(KeyCode.LeftArrow)) Debug.Log(KeyCode.LeftArrow);
    }
    void KeyCode_Function()
    {
        if (Input.GetKeyDown(KeyCode.F1)) Debug.Log(KeyCode.F1);
        if (Input.GetKeyDown(KeyCode.F2)) Debug.Log(KeyCode.F2);
        if (Input.GetKeyDown(KeyCode.F3)) Debug.Log(KeyCode.F3);
        if (Input.GetKeyDown(KeyCode.F4)) Debug.Log(KeyCode.F4);
        if (Input.GetKeyDown(KeyCode.F5)) Debug.Log(KeyCode.F5);
        if (Input.GetKeyDown(KeyCode.F6)) Debug.Log(KeyCode.F6);
        if (Input.GetKeyDown(KeyCode.F7)) Debug.Log(KeyCode.F7);
        if (Input.GetKeyDown(KeyCode.F8)) Debug.Log(KeyCode.F8);
        if (Input.GetKeyDown(KeyCode.F9)) Debug.Log(KeyCode.F9);
        if (Input.GetKeyDown(KeyCode.F10)) Debug.Log(KeyCode.F10);
    }
    void KeyCode_Alpha()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0)) Debug.Log(KeyCode.Alpha0);
        if (Input.GetKeyDown(KeyCode.Alpha1)) Debug.Log(KeyCode.Alpha1);
        if (Input.GetKeyDown(KeyCode.Alpha2)) Debug.Log(KeyCode.Alpha2);
        if (Input.GetKeyDown(KeyCode.Alpha3)) Debug.Log(KeyCode.Alpha3);
        if (Input.GetKeyDown(KeyCode.Alpha4)) Debug.Log(KeyCode.Alpha4);
        if (Input.GetKeyDown(KeyCode.Alpha5)) Debug.Log(KeyCode.Alpha5);
        if (Input.GetKeyDown(KeyCode.Alpha6)) Debug.Log(KeyCode.Alpha6);
        if (Input.GetKeyDown(KeyCode.Alpha7)) Debug.Log(KeyCode.Alpha7);
        if (Input.GetKeyDown(KeyCode.Alpha8)) Debug.Log(KeyCode.Alpha8);
        if (Input.GetKeyDown(KeyCode.Alpha9)) Debug.Log(KeyCode.Alpha9);
    }
    void KeyCode_Lock()
    {
        if (Input.GetKeyDown(KeyCode.Numlock)) Debug.Log(KeyCode.Numlock);
        if (Input.GetKeyDown(KeyCode.CapsLock)) Debug.Log(KeyCode.CapsLock);
        if (Input.GetKeyDown(KeyCode.ScrollLock)) Debug.Log(KeyCode.ScrollLock);
    }
    void KeyCode_Shift()
    {
        if (Input.GetKeyDown(KeyCode.RightShift)) Debug.Log(KeyCode.RightShift);
        if (Input.GetKeyDown(KeyCode.LeftShift)) Debug.Log(KeyCode.LeftShift);
    }
    void KeyCode_Control()
    {
        if (Input.GetKeyDown(KeyCode.RightControl)) Debug.Log(KeyCode.RightControl);    //노트북에 해당 키가 없다.
        if (Input.GetKeyDown(KeyCode.LeftControl)) Debug.Log(KeyCode.LeftControl);  
    }
    void KeyCode_Alt()
    {
        if (Input.GetKeyDown(KeyCode.RightAlt)) Debug.Log(KeyCode.RightAlt);    //노트북에 없는 키이다.
        if (Input.GetKeyDown(KeyCode.LeftAlt)) Debug.Log(KeyCode.LeftAlt);
    }

    void Update ()
    {
        KeyCode_AtoZ();
        KeyCode_Keypad();
        KeyCode_Arrow();
        KeyCode_Function();
        KeyCode_Alpha();
        KeyCode_Lock();
        KeyCode_Shift();
        KeyCode_Control();
        KeyCode_Alt();

        if (Input.GetKeyDown(KeyCode.Pause)) Debug.Log(KeyCode.Pause);  //KeyCode.Pause: Pause키를 나타낸다.
        if (Input.GetKeyDown(KeyCode.Escape)) Debug.Log(KeyCode.Escape);    //KeyCode.Escape: ESC키를 나타낸다.
        if (Input.GetKeyDown(KeyCode.Space)) Debug.Log(KeyCode.Space); //KeyCode.Space: Spacebar키를 나타낸다.

        if (Input.GetKeyDown(KeyCode.Insert)) Debug.Log(KeyCode.Insert);    //KeyCode.Insert: Insert키를 나타낸다.
        if (Input.GetKeyDown(KeyCode.Home)) Debug.Log(KeyCode.Home);    //노트북에 해당 키가 없다.
        if (Input.GetKeyDown(KeyCode.PageUp)) Debug.Log(KeyCode.PageUp);    //KeyCode.PageUp: PageUp키를 나타낸다.
        if (Input.GetKeyDown(KeyCode.PageDown)) Debug.Log(KeyCode.PageDown);    //KeyCode.PageDown: PageDown키를 나타낸다.

        if (Input.GetKeyDown(KeyCode.Quote)) Debug.Log(KeyCode.Quote);  //KeyCode.Quote: 작은따옴표를 나타낸다.

        if (Input.GetKeyDown(KeyCode.Minus)) Debug.Log(KeyCode.Minus);
        if (Input.GetKeyDown(KeyCode.Comma)) Debug.Log(KeyCode.Comma);
        if (Input.GetKeyDown(KeyCode.Period)) Debug.Log(KeyCode.Period);
        if (Input.GetKeyDown(KeyCode.Slash)) Debug.Log(KeyCode.Slash);
        if (Input.GetKeyDown(KeyCode.Semicolon)) Debug.Log(KeyCode.Semicolon);

        if (Input.GetKeyDown(KeyCode.Less)) Debug.Log(KeyCode.Less);
        if (Input.GetKeyDown(KeyCode.Equals)) Debug.Log(KeyCode.Equals);
        if (Input.GetKeyDown(KeyCode.Greater)) Debug.Log(KeyCode.Greater);
        if (Input.GetKeyDown(KeyCode.Question)) Debug.Log(KeyCode.Question);
        if (Input.GetKeyDown(KeyCode.At)) Debug.Log(KeyCode.At);
        if (Input.GetKeyDown(KeyCode.LeftBracket)) Debug.Log(KeyCode.LeftBracket);
        if (Input.GetKeyDown(KeyCode.Backslash)) Debug.Log(KeyCode.Backslash);
        if (Input.GetKeyDown(KeyCode.RightBracket)) Debug.Log(KeyCode.RightBracket);
        if (Input.GetKeyDown(KeyCode.Caret)) Debug.Log(KeyCode.Caret);
        if (Input.GetKeyDown(KeyCode.Underscore)) Debug.Log(KeyCode.Underscore);
        if (Input.GetKeyDown(KeyCode.BackQuote)) Debug.Log(KeyCode.BackQuote);
        
    }
    /*
    LeftCommand	키보드의 왼쪽 Apple키를 나타냅니다.
LeftApple	키보드의 왼쪽 Apple키를 나타냅니다.
LeftWindows	키보드의 왼쪽 Windows키를 나타냅니다.
RightCommand	키보드의 오른쪽 Apple키를 나타냅니다.
RightApple	키보드의 오른쪽 Apple키를 나타냅니다.
RightWindows	키보드의 오른쪽 Windows 키를 나타냅니다.
AltGr	키보드의 Alt Gr키를 나타냅니다.
Help	Help 키를 나타냅니다.
Print	Print 키를 나타냅니다.
SysReq	Sys Req 키를 나타냅니다.
Break	키보드의 Break키를 나타냅니다.
Menu	Menu키를 나타냅니다.
Mouse0	첫번째 마우스 버튼을 나타냅니다.
Mouse1	두번째 마우스 버튼을 나타냅니다.
Mouse2	마우스의 세번째 버튼을 나타냅니다.
Mouse3	마우스의 네번째 버튼을 나타냅니다.
Mouse4	마우스의 다섯번째 버튼을 나타냅니다.
Mouse5	마우스의 여섯번째 버튼을 나타냅니다.
Mouse6	마우스의 일곱번째 버튼을 나타냅니다.
     */
}

/*
안되는키들 같다.
KeyCode.None
KeyCode.Backspace
KeyCode.Clear
KeyCode.KeypadEquals

못찾는 키들이다.
KeyCode.Exclaim
KeyCode.Hash
KeyCode.LeftParen
KeyCode.RightParen
KeyCode.At
KeyCode.Caret
KeyCode.LeftCommand
KeyCode.RightCommand

쉬프트 누르고 눌러도 안되는 키들이다.
KeyCode.DoubleQuote
KeyCode.Dollar
KeyCode.Ampersand
KeyCode.Plus
KeyCode.Asterisk
KeyCode.Colon
KeyCode.Less
KeyCode.Greater
KeyCode.Question
KeyCode.Underscore

노트북에 없는 키들이다.
KeyCode.Home
KeyCode.KeypadEquals
KeyCode.RightControl
KeyCode.RightAlt
KeyCode.RightApple

 */
