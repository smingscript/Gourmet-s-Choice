# 푸드 월드컵 - 오늘은 뭐 먹을까요?(Project Gourmet-s-Choice)
이 프로젝트는 유명한 "○○○ 월드컵 게임"을 Winform 환경에서 구현하였습니다. 어떤 메뉴를 먹을지 쉽게 결정을 못 내릴 때, 데이터베이스의 메뉴 중에 랜덤으로 8강/16강의 토너먼트를 걸쳐, 가장 먹고 싶은 메뉴를 선택할 수 있습니다.

## 시작하기
### 프로그램 사용하기
> 1. `Food.bak` 백업 파일을 MS SQL Server의 데이터 베이스에 복원합니다.
> 2. Gourmet-s-Choice.sln 솔루션 파일을 엽니다.
> 3. `App.config` 파일의 `<connectionStrings>`의 `data source=[SQL Server ip];initial catalog=Food;user id=[SQL Server id];password=[SQL Server pw]`로 수정합니다.
> 4. 프로젝트를 빌드합니다.
> 5. bin/Debug/Gourmet-s-Choice.exe를 실행합니다. 

### 데이터베이스에 새 메뉴 추가하기
> 1. 위 "프로그램 사용하기"의 1~3가 미리 설정되어 있어야 합니다.
> 2. `Program.cs`파일에서 `Application.Run(new StartForm());` 부분을 주석 처리하고, `Application.Run(new ImageUploader());`의 주석을 지웁니다.
> 3. 데이터베이스에 업로드할 이미지 파일을 한 폴더 안에 준비합니다.
> 4. `ImageUploader.cs`의 `string thumbPath = $"C:\\[저장하는 파일 경로]\\thumbnail_{fileName}.jpg";`로 수정합니다.
> 5. 프로젝트를 빌드합니다.
> 6. bin/Debug/Gourmet-s-Choice.exe를 실행합니다.

## 개발환경
- C# 설치 버전: .NET Framework 4.6.1 / Entity Framework v6.2.0 
- IDE: Visual Studio 2017

## 참고
구글 플레이 앱 - **푸드월드컵**(개발자: houng_s_j)

## 라이선스
This project is licensed under the MIT License
