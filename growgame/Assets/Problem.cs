﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class Problem : MonoBehaviour {

    public String[,] que =
     {
        {"1","클래스는 뭐하라고 있는 것? (    ) 만들라고 있는 것!"+"\n\n1. 객체  2. 무결성  3. 데이터" },
        { "2","컴퓨터에서 실수를 표현하는 방식 중 하나인 (  )은  실수를 가수와 지수로 나누어 표현하여 표현할 수 있는 실수의 범위를 확장시킨다." +"\n\n1. 고정 소수점  2. 부동 소수점  3. 정수 부분 "},
        { "1","□(int I=0; I<3; I++) { \n print(“Hello world”); \n} 일 때 네모 안에 들어갈 명령어는?"+"\n\n1. for  2. switch  3. if"},
        { "2", "X += Y와 같은 식은?"+"\n\n 1. X = X-Y  2. X = X+Y  3. X == Y"},
        { "3", "조건문에서 생략 가능한 명령어는?"+"\n\n1. else if  2. if  3. else" },
        {"1","PHP에서 변수 선언을 위해 사용하는 특수문자는 무엇인가?"+"\n\n1. $  2. !  3.*" },
        {"1","인접한 2개의 원소를 비교하면서 값을 정렬하는 정렬 방식은?"+"\n\n1. 버블정렬  2. 선택정렬  3. 삽입정렬" },
        {"3","웹 페이지에서 데이터를 표시하지 않고 숨긴 상태로 웹 서버의 해당 파일에 데이터를 전달해주는 명령어는?"+"\n\n1. checkbox  2. post  3. hidden"},
        { "1", "오늘날 컴퓨터가 따르는 (  )은/는 실행하려는 프로그램이 전부 메모리 위에 올라와야하는 구조이다. " +
                "\n\n1. 폰노이만 구조   2. 양자구조   3. 계층구조" }, 
        { "3", "(  )은/는 메모리와 cpu간의 속도 차이를 완화하기 위해 메모리의 데이터를 미리 가져와 저장해두는 임시 장소이다. " + "\n\n1. 레지스터  2. 스풀  3. 캐시"},
        {"2" , "프로세스의 상태도에서 프로세스가 (  )로 가려면 반드시 디스패치를 거쳐야 한다. "+"\n\n1. 재시작  2. 실행상태  3. 타임아웃" },
        {"2", "CPU를 차지하던 프로세스가 나가고 새로운 프로세스를 받아들이는 작업을 (  )이라고 한다. "+"\n\n1. 멀티스레드  2. 문맥교환  3. 시스템 호출"},
        {"3","CPU 스케줄링 알고리즘인 (  ) 스케줄링은 비선점 알고리즘에 하나로 오래 기다릴수록 우선순위가 상승해 최고 응답률 우선 스케줄링이라고 불린다."+ "\n\n1. SIF  2. FCFS  3. HRN"},
        {"1","(  )란, 2개 이상의 프로세스가 다른 프로세스의 작업이 끝나기만을 기다리며 작업을 더 이상 진행하지 못하는 상태를 말한다." + "\n\n1. 교착 상태  2. 이벤트  3. 헨들러"},
        {"2","프로그램이 실행을 위해 올라온 동적인 상태를 (  )라고 한다."+"\n\n1. 스레드  2. 프로세스  3. 커널" },
        {"1","(  )는 논리메모리를 물리메모리로 1대1 mapping을 해준다. 또한 프로세스와 데이터를 메모리로 가져오고 배치하고 메모리가 가득 찰 경우 프로세스와 데이터를 재배치 한다."+
                "\n\n1.메모리 관리자  2. 메모리 할당  3. 관리자 모드"},
        {"3","실제 물리주소를 가리키는 (  )은/는 메모리 관리자 입장에서 바라본 주소이다. 메모리 제스터가 사용하는 주소로 컴퓨터에 꽂힌 램의 실제 주소를 말한다." +"\n\n1. 상대주소  2. 논리주소  3. 절대주소"},
        {"3","(  ) 분할 방식으로 메모리를 분할할 경우 프로세스가 연속된 공간에 배치되며 연속 메모리 할당이라고 불린다."+"\n\n1. 고정  2. 분배  3. 가변"},
        {"1","가상 메모리 관리 기법에서 고정 분할 방식을 사용하는 기법은?" +"\n\n1. 페이징  2. 세그먼트  3. 프로세싱"},
        {"1","사용자가 필요한 페이지를 메모리로 가져오는 것을 (  )이라고 한다."+"\n\n1. 요구 페이징  2. 지역성  3. 페이지 교체"},
        {"2","페이지 교체 알고리즘의 (  )는 메모리에 올라온 시간을 기준으로 가장 오래된 페이지를 교체한다."+"\n\n1. LFU  2. LRU  3. FIFO"},
        {"3","(  )이란 하드디스크이 입출력이 너무 많아져서 잦은 페이지 부재로 작업이 멈춘 것 같은 상태를 말한다."+"\n\n1. 프레임  2. 스왑  3. 스레싱"},
        {"1","하드 디스크 같은 대용량 저장장치는 처음 사용할 때 (  )을 나눠준다. (  )이란 디스크를 논리적으로 분할하는 작업이다."+"\n\n1. 파티션  2. 테이블  3. 포매팅"},
        {"2","하드 디스크를 사용하면서 파일을 저장하고 지우다보면 중간중간에 빈 공간이 생기는데 이를 (  )라고 한다."+"\n\n1. DAS  2. 조각화  3. 포매팅"},
        {"3","(  )은 사용자가 직접 파일을 보관하거나 접근하지 못하도록 하여 사용자가 파일을 훼손하는 문제를 방지한다."+"\n\n1. 파일 헤더  2. 파일 테이블  3. 파일 시스템"},
        {"2","네트워크상에 분산되어 있는 컴퓨터가 작업을 처리하고 그 내용이나 결과를 교환하는 방식을 (  )이라고 한다."+"\n\n1. P2P 2. 분산 시스템  3. 서버"}

    };

    public String[,] que2 =
    {
        {"1","데이버베이스 모델에서 가장 자주 이용되는 데이터 모델은 무엇일까?" +"\n\n1. 관계 데이터 모델  2. 계층 데이터 모델  3. 객체 데이터 모델" },
        {"1","(  )은 릴레이션의 기본키는 null 값을 가질 수 없으며 속성이 지정한 도메인 값만 가져야한다."+"\n\n1. 개체 무결성  2. 참조 무결성  3. 도메인 무결성"},
        {"3","sql 언어에서 GROUP BY 절의 결과를 나타나는 그룹을 제한해주는 명령어는 무엇인가?"+"\n\n1. SELECT  2. WHERE  3. HAVING" },
        {"2","후보키 중에 (  )로 선택되지 못한 키를 대체키라고 한다."+"\n\n1. 슈퍼키  2. 기본키  3. 외래키" },
        {"2","Oracle에서 외래키를 지정해주는 명령어는 무엇인가?"+"\n\n1. Primary key  2. Foreign key  3. References" },
        {"3","데이터베이스의 특징이 아닌 것은?"+"\n\n1. 실시간 접근성  2. 동시공유  3. 비지속적 변화" },
        {"1","릴레이션에서 투플을 추출하기 위해 사용하는 관계대수 연산은 무엇일까?"+"\n\n1. 셀렉션  2. 조인  3. 프로젝션" },
        {"2","(  )이란 릴레이션에 포함된 각각의 속성들이 가질 수 있는 값들의 집합이다."+"\n\n1. 튜플  2. 도메인  3. 차수" },
        {"3","상위 개체 타입이 결정되지 않으면 개별 개체를 식별할 수 없는 종속적인 개체타입을 (  ) 개체 타입이라고 한다."+"\n\n1. 중간  2. 강한  3. 약한" },
        {"1", "sql에서 다음 중 데이터 정의어가 아닌 것은?"+"\n\n1. REVOKE  2. CREATE  3. ALTER"},
        {"2","데이블에 있는 기존 튜플을 삭제하는 SQL 명령어는?"+"\n\n1. REMOVE  2. DELETE  3. DROP" },
        {"3","(  )는 다음에 실행할 명령어 주소를 저장하는 레지스터이다."+"\n\n1. AC  2. TR  3. PC" },
        {"1","어셈블리 언어는 (  ), 명령어, 코멘트 필드 순으로 되어있다."+"\n\n1. 라벨  2. 주소  3. 슈도"},
        {"1","하나의 프로세스를 서로 다른 기능을 가진 여러 개의 서브 프로레스로 나눠 각 서브 프로세스가 동시에 다른 데이터를 취급하도록 하는 방식을 (  )이라고 한다."+
                "\n\n1. 파이프라인  2. 배열프로세르  3. 일괄처리"},
        {"2","직접 메모리 접근인 (  )는 CPU의 버스 선을 빌려 CPU의 간섭 없이 스스로 입출력을 처리하는 시스템이다."+"\n\n1. RD  2. DMA  3. ACK "},
        {"2","언어의 번역 방법인 (  )은 고급 언어로 작성된 원시 프로그램을 한 줄씩 읽어드려 번역한다. 주로 PHP와 파이썬에서 사용된다." +"\n\n1. 컴파일러  2. 인터프리터 기법  3. 번역 기법"},
        {"1","(  )문은 다른 제어문의 사용 없이 모든 알고리즘을 해결할 수 있다. 하지만 프로개름의 판독성을 저하해 사용을 막거나, 사용하기 불편하게 만드는 경우가 많다."+"\n\n1. goto  2. alias  3. BECOND" },
        {"1","(  )은 C언어 포인터의 부수효과중 하나로 이름은 다르지만 동일한 기억장소를 사용하는 것이 특징이다."+ "\n\n1. 이명  2. 중복표현  3. 매개변수" },
        {"3","(  )는 예상되는 오류를 미리 처리하여 에러가 발생하는 상황을 막고 프로그램이 중간에 중단되지 않고 계속 실행되게 해준다."+"\n\n1. 프로세스  2. 루틴  3. 예외처리" },
        {"1","모든 연산이 누산기에서 이루어져 발생하는 (  )은 명령형 언어의 하드웨어적인 문제 중 하나이다." +"\n\n1. 병목  2. 폰노이만  3. LISP"},
        {"2","컴파일러를 통해 만들어진 obj파일을 (  )가 완벽하게 기계어로 번역한다."+"\n\n1. Linker  2. Loader  3. Preprocesser" },
        {"2"," 한 개의 언어가 M개의 기계에서 번역되려면 몇 개의 컴파일러가 필요한가?"+"\n\n1. 1개  2. M개  3. M+1개" },
        {"3","실행시간에 기억장소를 할당하는 동적 기억장소 할당 방식은 (  ) 영역을 사용한다." +"\n\n1. stack  2. offset  3. heap"},
        {"1","번역시간에 기억장소를 할당하는 정적 기억장소를 (  )이 불가능하지만 실행시간에 기억공간을 할당하는 동적 기억장소는 (  )이 가능하다"+"\n\n1. Recursion  2. Binding  3. Segement"},
        {"1","에러 감지 기술 중 하나인 (  )은 Nbit씩 잘라진 메시지를 더한 값을 redundancy로 사용하여 에러 검출을 한다." +"\n\n1. Checksum  2. Parity  3. CRC"},
        {"2","데이터 링크 계층에서 수신단이 송신단에게 Frame을 받았다고 알려주는 통신 용어는?"+"\n\n1. RR  2. Ack  3. Resent" },
        {"3","HDLC에서 (  )은 데이터를 보내는 프레임이다."+"\n\n1. S-frame  2. U-frame  3. I-frame" },
        {"1","PAP방식으로 통신을 할 경우는 password가 그대로 노출될 수 있는 가능성이 있기 때문에 password를 특정한 값으로 바꿔서 보내는 (  )가 등장했다."+"\n\n1. CHAP  2. SREI  3. RNRI"},
        {"2","이더넷의 frame 중에 데이터와 패딩 영역이 들어가는 부분은 최대 몇 byte까지 가능한가?"+"\n\n1. 1400  2. 1500  3. 1600" },
        {"2","이더넷의 주소에서 첫 byte 시작 bit가 1일 경우 어떤 방식으로 통신을 하는가?"+"\n\n1. broadcast  2. multicast  3. unicast" },
        {"1"," (  )는 초당 주기를 의미하여 주기의 역수 값을 가진다." +"\n\n1. 주파수  2. 진폭  3. 파장"},
        {"3","PCM은 아날로그 신호를 (  ) 하고 이를 인코딩하여 정규화를 거처 디지털 신호를 만들어낸다." +"\n\n1. 진폭화  2. 시퀸스  3. 샘플링"},
        {"3","Multiplexing 방식 중 하나인 (  )은 전송 시간을 슬롯 단위로 쪼개 데이터를 전송시키는 방식이다." +"\n\n1. FDM  2. WDM  3. TDM"},
        {"2","Optical fiber에서 가장 감쇠가 적은 nm은?"+"\n\n1. 850nm  2. 1550nm  3. 1350nm" }     
    };


    public Text queText;
    public int num=0;
    public int num2 = 0;
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

        if (num==que.Length)
        {
            num = 0;
        }

        /*꽃일때 문제바뀜*/
        if(GetPoint.waterpoint >= 100 && MinGetPoint.sunpoint >= 50)
        {
            if(num2 == num) {

                move.count2 = 0;

            }

            queText.GetComponent<Text>().text = que2[num2, 1];
            ans = int.Parse(que2[num2, 0]);

            int temp2 = num2;
            num2 = move.Getcount2();

            if (num2 != temp2)
            {
                queText.GetComponent<Text>().text = que2[num2, 1];
                ans = int.Parse(que2[num, 0]);
            }

            if (num2 == que.Length)
            {
                num2 = 0;
            }
        }
        
        
	}
}
