﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class Problem : MonoBehaviour {


     public String[,] que =
     {
        { "2","컴퓨터에서 실수를 표현하는 방식 중 하나인 (  )은  실수를 가수와 지수로 나누어 표현하여 표현할 수 있는 실수의 범위를 확장시킨다." +"\n\n1. 고정 소수점  2. 부동 소수점  3. 정수 부분 "},
        { "1","□(int I=0; I<3; I++){print(“Hello world”);} 일 때 네모 안에 들어갈 명령어는?"+"\n\n1. for  2. switch  3. if"},
        { "2", "X += Y와 같은 식은?"+"\n\n 1. X = X-Y  2. X = X+Y  3. X == Y"},
        { "3", "조건문에서 생략 가능한 명령어는?"+"\n\n1. else if  2. if  3. else" },
        { "2","v가 소문자인지 판별하기 위해 사용하는 명령어는?"+"\n\n1. isupper(v)  2. islower(v)  3. isalnum(v)" },
        { "1", "오늘날 컴퓨터가 따르는 (  )은/는 실행하고자 하는 프로그램이 메모리 위에 전부 올라와야하는 구조로 하드웨어는 그대로 둔 채 작업을 이한 프로그램만 교체하여 메모리에 올린다. " +
                "\n\n1. 폰노이만 구조   2. 양자구조   3. 계층구조" }, 
        { "3", "(  )은/는 메모리와 cpu간의 속도 차이를 완화하기 위해 메모리의 데이터를 미리 가져와 저장해두는 임시 장소이다. " + "\n\n1. 레지스터  2. 스풀  3. 캐시"},
        {"2" , "프로세스의 상태도에서 프로세스가 (  )로 가려면 반드시 디스패치를 거쳐야 한다. "+"\n\n1. 재시작  2. 실행상태  3. 타임아웃" },
        {"2", "CPU를 차지하던 프로세스가 나가고 새로운 프로세스를 받아드리는 작업을 (  )이라고 한다. "+"\n\n1. 멀티스레드  2. 문맥교환  3. 시스템 호출"},
        {"3","CPU 스케줄링 알고리즘인 (  ) 스케줄링은 비선점 알고리즘에 하나로 오래 기다릴수록 우선순위가 상승해 최고 응답률 우선 스케줄링이라고 불린다."+ "\n\n1. SIF  2. FCFS  3. HRN"},
        {"1","(  )란, 2개 이상의 프로세스가 다른 프로세스의 작업이 끝나기만을 기다리며 작업을 더 이상 진행하지 못하는 상태를 말한다." + "\n\n1. 교착 상태  2. 이벤트  3. 헨들러"},
        {"2","프로그램이 실행을 위해 올라온 동적인 상태를 (  )라고 한다."+"\n\n1. 스레드  2. 프로세스  3. 커널" },
        {"1","(  )는 논리메모리를 물리메모리로 1대1 mapping을 해준다. 또한 프로세스와 데이터를 메모리로 가져오고 배치하고 메모리가 가득 찰 경우 프로세스와 데이터를 재배치 한다."+
                "\n\n1.메모리 관리자  2. 메모리 할당  3. 관리자 모드"},
        {"3","실제 물리주소를 가리키는 (  )은/는 메모리 관리자 입장에서 바라본 주소이다. 메모리 제스터가 사용하는 주소로 컴퓨터에 꽂힌 램의 실제 주소를 말한다." +"\n\n1. 상대주소  2. 논리주소  3. 절대주소"},
        {"2","프로그램의 크기가 실제 메모리보다 클 때 전체의 프로그램을 메모리에 가져오는 대신 적당한 크기로 잘라 메모리로 가져오는 메모리 (  )은/는 적은 용량의 메모리로 큰 프로그램을 실행할 수 있게 도와준다."+
                "\n\n1. 스왑  2. 오버레이  3. 유닉스"},
        {"3","(  ) 분할 방식으로 메모리를 분할할 경우 프로세스가 연속된 공간에 배치되며 연속 메모리 할당이라고 불린다."+"\n\n1. 고정  2. 분배  3. 가변"},
        {"1","가상 메모리 관리 기법에서 고정 분할 방식을 사용하는 기법은?" +"\n\n1. 페이징  2. 세그먼트  3. 프로세싱"},
        {"1","사용자가 필요한 페이지를 메모리로 가져오는 것을 (  )이라고 한다."+"\n\n1. 요구 페이징  2. 지역성  3. 페이지 교체"},
        {"2","페이지 교체 알고리즘의 (  )는 메모리에 올라온 시간을 기준으로 가장 오래된 페이지를 교체한다."+"\n\n1. LFU  2. LRU  3. FIFO"},
        {"3","(  )이란 하드디스크이 입출력이 너무 많아져서 잦은 페이지 부재로 작업이 멈춘 것 같은 상태를 말한다."+"\n\n1. 프레임  2. 스왑  3. 스레싱"},
        {"3","표면에 미세한 홈이 파여 헤드에서 발사된 레이저가 반사되지 않으면 0, 반사되지 않으면 1로 인식하는 (  )는 레이저를 쏘아 표면을 태워 홈을 만드는 방식으로 데이터를 저장한다."+
                "\n\n1. 디스크  2. USB  3. CD"},
        {"1","하드 디스크 같은 대용량 저장장치는 처음 사용할 때 (  )을 나눠준다. (  )이란 디스크를 논리적으로 분할하는 작업이다."+"\n\n1. 파티션  2. 테이블  3. 포매팅"},
        {"2","하드 디스크를 사용하면서 파일을 저장하고 지우다보면 중간중간에 빈 공간이 생기는데 이를 (  )라고 한다."+"\n\n1. DAS  2. 조각화  3. 포매팅"},
        {"2","하드 디스크의 스케줄링인 (  ) 디스크 스케줄링은 마지막 트랙에 도착할 때까지 뒤돌아가지 않으며 계속 앞으로 나가면서 요청받은 트랙을 서비스한다."+
                "\n\n1. SSTF  2. SCAN  3. LOOK"},
        {"3","(  )은 사용자가 직접 파일을 보관하거나 접근하지 못하도록 하여 사용자가 파일을 훼손하는 문제를 방지한다."+"\n\n1. 파일 헤더  2. 파일 테이블  3. 파일 시스템"},
        {"1","네트워크로 연결된 모든 컴퓨터 프로게서가 하나의 메모리를 공유하는 방식을 (  )이라고 한다."+"\n\n1. 강결합  2. 약결합  3. 프로토콜"},
        {"2","네트워크상에 분산되어 있는 컴퓨터가 작업을 처리하고 그 내용이나 결과를 교환하는 방식을 (  )이라고 한다."+"\n\n1. P2P 2. 분산 시스템  3. 서버"}

    }; 
 

    public Text queText;
    public int num=0;    
    public move move;
    public int ans = 0;

    void Awake()
    {
        move=GameObject.Find("soil_shoot").GetComponent<move>();
    }

    // Use this for initialization
    void Start () {
        queText.GetComponent<Text>().text = que[0, 1];
        ans = int.Parse(que[0, 0]);
    }
	
	// Update is called once per frame
	void Update () {
        int temp = num;
        num = move.Getcount();
        //Debug.Log(num);
        

        if (num != temp)
        {
            queText.GetComponent<Text>().text = que[num, 1];
            ans = int.Parse(que[num, 0]);
        }
        
	}
}
