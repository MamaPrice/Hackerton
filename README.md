팀명
====
엄마 나 상탔어

제출 세션 및 주제
=================
특별세션 - 랜드마크 연계 관광자원 발굴

프로젝트 한 줄 설명
==================
AR을 이용한 관광게임으로 대구 랜드마크 및 지역 상권 활성화

프로젝트에 대한 설명
====================
주제
----
>잡아보니 대구: 대구 랜드마크 관광 AR 게임
GPS를 이용한 현장 체험형 AR 관광 게임으로 메타버스와 증강현실을 기반으로한 여행과 게임을 결합한 융합형 콘텐츠

목적
----
>대구 랜드마크 관광 활성화를 위해 AR 관광 콘텐츠를 기획

기존 관광앱이 관광객의 흥미를 끌지 못한 문제점을 게임으로 해결하고자함.
비슷한 사례인 ‘포켓몬 고’ 와 같이 다양한 연령대의 관광객의 시선을 사로잡고,
관광지의 랜드마크를 가도록 유도 함으로서 지역경제 활성화 및 랜드마크 홍보가 주목적임.

기존 관광앱의 문제점과 차별성
-----------------------------
1. 기존 관광 앱은 랜드마크와 관련된 체험적인 요소가 부족
    → AR을 활용하여 현장 체험형 콘텐츠 제공
    
2. 관광지와 적합하지 않는 UI
    → 대구의 랜드마크 및 마스코트를 캐릭터화 시켜 대구에 적합한 UI 적용
    
3. 랜드마크에 대한 부족한 정보 제공
    → 마스코트 및 랜드마크의 소개를 통해 유익한 정보 제공


게임 설명
---------
### 화면
#### 1. 메인 화면
    - 보유한 대구 마스코트 캐릭터가 화면에 돌아다님
    - 클릭시 캐릭터가 반응하며 게임코인 증가
    - 대구 랜드마크 별로 마스코트 캐릭터, 인테리어 구현
    - 게임 코인으로 구매한 아이템으로 배경 꾸미기

![Scene_main](/README_IMG/Scene_main.png)
    
#### 2. 장소 선택 화면
    - 대구의 랜드마크 5곳 (경북대, 동성로, 수성못, 앞산, 디아크) 중 투어 할 장소 선택
    - 랜드마크 선택시 코스 선택 가능
    (예시: 경북대 코스 - 일청담, 정문, 도서관, 북문, 대운동장)

![Scene_map](/README_IMG/Scene_Map.png)
    
#### 3. 투어화면
    - 랜드마크의 코스 투어시 AR화면 전환
    - 화면 안에서 랜드마크의 마스코트를 찾으면 찰칵 버튼을 통해 캐릭터 잡기 가능
    - 마스코트를 잡으면 해당 코스 clear
    - 랜드마크의 모든 코스 clear시 마스코트 캐릭터 잠금 해제 가능

![Scene_KNU](/README_IMG/Scene_KNU.png)
    
#### 4. 컬렉션 화면
##### 1) 캐릭터 컬렉션
    - 캐릭터 리스트 볼수있음
    - 잠금 해제한 캐릭터 클릭시 메인 화면에 캐릭터 생성 및 간단한 캐릭터 설명 제공

![Scene_character](/README_IMG/Scene_Character.png)
#### 2) 인테리어 컬렉션 
    - 대구를 대표하는 랜드마크의 인테리어 구매 및 가능
        
![Scene_interior](/README_IMG/Scene_Interior.png)

### 코인
#### 1. 지역 코인(오른쪽 상단)
    - 획득: 랜드마크의 모든 코스 clear시 획득 가능
    - 사용: 대구시 행복 페이로 대구시 내에서 지역 화폐로 사용 가능
#### 2. 게임 코인(왼쪽 상단)
    - 획득: 캐릭터 클릭시 일정 코인 획득
    - 사용: 메인화면에서 인테리어 아이템 구매 가능

기대 효과
---------
AR 콘텐츠를 통해 여행의 생생한 체험 가능
대구 랜드마크와 마스코트 홍보
대구 지역 상권 활성화

게임 화면 구조
--------------
![game structure](/README_IMG/game_structure.png)

프로젝트에 활용된 기술
======================
1 - unity2D 사용
---------------
    a. Visual Scripting을 이용하여  기본 로직인 매크로와 슈퍼유닛 설정
    b. C# 스크립트를 작성해 오브젝트의 변수 설정 및 함수 구현
    c.  PlayerPrefab을 이용하여 Unity내 레지스트리에 값을 저장해 데이터 저장 및 초기화
    d. GameManager의 Variables를 통해 Scene간 변수 활용

2 - unity AR Foundation, AR core, gps, go map사용
--------------------------------------------------
    a. go map을 사용하여 원하는 위도 경도에 3D 오브젝트를 맵핑후 xml파일로 받아옴
    b. 휴대폰의 gps를 활용하여 현재 위치를 받아옴
    c. AR Foundation과 AR core를 이용하여 휴대폰을 활용한 증강현실 구현
    d. 3D 오브젝트를 증강현실 안에서 인식 및 floor를 인식하여 바닥 위에 거리와 그림자 구현

a) gomap과 xml 사용
![gomap_xml](/README_IMG/gomap_and_xml.png)
b) AR화면
![ar_screen](/README_IMG/AR.png)

3 - 포토샵, piskel, autocad 등 디자인 툴 사용
---------------------------------------------
### 대구의 랜드마크, 마스코트 아이콘화
    a. Photoshop - 누끼 제거, 그림자 생성, 획 및 테두리 변경
    b. 필터 갤러리 - 텍스쳐화
    c. Piskel - 모든 픽셀 이미지 디자인, 2D 이미지 간략하게 3D로 변경
    d. Autocad - AR 작업에서 필요한 모든 3D 이미지 수정 및 디자인
    e. 피그마, 미리캔버스 - 게임 UI 설계 및 디자인

a) photoshop
![photoshop](/README_IMG/photoshop_pixel.png)
b) photoshop2
![photoshop2](/README_IMG/pixel.png)
c) piskel
![piskel](/README_IMG/piskel.png) 
d) autocad
![autocad](/README_IMG/autocad.png) 
e) figma
![figma](/README_IMG/figma.png) 

시연영상
========
[시연 영상 보러가기](https://www.youtube.com/watch?v=sfc4P7Ap9pk)

깃 허브 브랜치 설명
===================
디자이너: Sub_J    
UI 및 프론트: ajin, KAJ    
AR 기능: KDW4       
캐릭터 키우기 게임: DW1 - DW6      

를 참고해주세요