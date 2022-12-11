# **Rolling Stones Game**
![Rolling Stones Screenshot](https://user-images.githubusercontent.com/113342005/206895222-23149c36-0cd7-4ce4-a167-a8ae32521f9f.png)


## Introduction
* SeulTech 오픈소스소프트웨어 term project로 개발했습니다.
* Unity 3D툴을 이용한 게임을 제작했습니다.
* [Roll-a-Ball](https://learn.unity.com/project/roll-a-ball-1)이라는 Unity3D 예제를 응용하여 게임을 제작했습니다.

## Description

* 방향키로 조작하며 space bar로 점프할 수 있습니다.
* 4개의 스테이지로 구성되어 있으며 스테이지 내에 존재하는 모든 아이템을 먹고 출구로 가면 다음 스테이지로 넘어갈 수 있습니다.
* 스테이지의 아이템을 모두 먹지 못한 상태에서 출구로 가거나 필드에서 떨어지게 된다면 스테이지를 처음부터 시작합니다.
* ESC버튼을 눌러 언제든지 게임을 종료할 수 있습니다.

## About Assets
  * :loud_sound: CasualGameSound
    * Unity Asset Store에서 무료로 제공하는 [CasualGameSound](https://assetstore.unity.com/packages/audio/sound-fx/free-casual-game-sfx-pack-54116)를 사용했습니다.
  
  * :microscope: Meterial
    * 게임 속 3D 오브젝트의 Meterial과 Texture의 소스입니다.
  
  * :film_projector: Scenes
    * 게임을 구성하는 4개의 스테이지입니다.
  
  * :page_facing_up: Script
    * CameraMove.cs //플레이어를 따라다니는 카메라의 움직임에 관한 코드입니다.
    * GameManagerLogic.cs //UI, 아이템의 카운트 등의 게임의 전반적인 로직을 구성하는 코드입니다. 
    * ItemBar.cs  //아이템의 회전에 관한 코드입니다.
    * StoneBall.cs  //플레이어의 움직임과 조작을 총괄하는 코드입니다.


## Game Play
https://user-images.githubusercontent.com/113342005/206895266-197b2cd1-a56c-4f74-8311-684f8e1915dd.mp4

## References
  * [Roll-a-Ball](https://learn.unity.com/project/roll-a-ball-1)
  * https://answers.unity.com/questions/161858/startstop-playmode-from-editor-script.html // 게임종료코드 참고
  * https://youtu.be/Gcoj3llfzSw //Unity 공식 델타타임 참고

## LICENCE
  * MIT
