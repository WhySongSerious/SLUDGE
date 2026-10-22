# SLUDGE

광교호수공원의 환경오염을 주제로, 실제 장소를 방문해 AR 콘텐츠를 체험하는 Unity 모바일 프로젝트입니다.

| 항목 | 내용 |
| --- | --- |
| 기간 | 2024.09 – 2024.12 |
| 엔진 | Unity 2022.3.50f1 · C# |
| 플랫폼 | Android (GPS · 카메라) |
| 주요 기술 | AR Foundation, Unity Location Service |

## 내가 맡은 일 — 송재혁

기획·스토리 구성부터 위치 판정과 AR 화면 구현까지 개발 전반을 맡았습니다.

- **위치 판정:** Android 위치 권한을 요청한 뒤 GPS를 시작하고, 초기화 시간 초과나 위치 서비스 실패 시 진행을 멈춥니다. 현재 좌표와 지정 장소 좌표 사이의 지표면 거리를 계산해, 목표 지점에 들어오면 환영 팝업을 한 번만 띄웁니다. 현장 테스트용으로 현재 위도·경도를 화면에 표시합니다.
- **AR 평면:** AR Foundation이 인식한 평면에 콘텐츠용 머티리얼을 입히고, 배치가 끝나면 평면 인식을 끄고 감지된 평면을 숨겨 화면을 정리합니다.
- **씬 흐름:** 시작 화면에서 메인 게임으로 넘어가는 전환을 연결했습니다.

## 코드 위치

| 내용 | 경로 |
| --- | --- |
| GPS 위치 판정 | [`Assets/Scripts/GPSManager.cs`](Assets/Scripts/GPSManager.cs) |
| AR 평면 처리 | [`Assets/Scripts/ChangePlaneMaterial.cs`](Assets/Scripts/ChangePlaneMaterial.cs) |
| 씬 전환 | [`Assets/Scripts/LoadToMainGame.cs`](Assets/Scripts/LoadToMainGame.cs) |

## 실행

1. Unity 2022.3.50f1로 프로젝트를 엽니다.
2. `Assets/Scenes/GameStratScene.unity`에서 시작합니다.
3. GPS와 AR 기능은 ARCore를 지원하는 Android 기기에서 확인할 수 있습니다.

## 참고

- 저장소는 완성 시점의 프로젝트를 한 번에 업로드한 것이라 개발 과정의 커밋 기록은 남아 있지 않습니다.
- `GPSManager.cs`의 도착 판정 거리 값은 테스트용으로 크게 설정되어 있습니다.
