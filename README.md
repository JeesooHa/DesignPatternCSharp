# DesignPatternCSharp

## 기초지식

### Design Pattern 이란?
```
* 프로그램을 개발하는 과정에서 빈번하게 발생하는 디자인 상의 문제를 정리해서, 상황에 따라 간편하게 적용해서 쓸 수 있는 패턴 행태로 만든 것
* 어울리지 않는 상황에서 남용 시 역효과가 날 수 있음
 => 경험과 지식을 바탕으로 현명하게 활용하는 방법 깨닫기!
```

### <Design 원칙>

1) 애플리케이션에서 달라지는 부분을 찾아내고, 달라지지 않는 부분으로 부터 분리시킨다

2) 구현이 아닌 **인터페이스**에 맞추서 프로그래밍 한다.
    * 실제 실행시에 쓰이는 객체가 코드에 의해서 고정되지 않도록, 어떤 상위형식(Supertype)에 맞춰서 프로그래밍 => 다형성 활용
    * 변수 선언 시 추상 클래스(abstract class)나 인터페이스(interface) 같은 상위 형식으로 선언
    * 실행 시 동적으로 같은 인터페이스로 구현한 다른 클래스 할당 가능
  
3) 상속보다는 구성(Composition)을 활용한다. 

4) 서로 상호작용을 하는 객체 사이에는 가능하면 느슨하게 결합하는 디자인을 사용해야 한다.
5) 




## Design 패턴
----
## Ch1. 스트래티지 패턴 (Strategy Pattern)
```
* 알고리즘군을 정의하고 각각을 캡슐화하여 교환할 수 있도록 함
* 알고리즘을 사용하는 클라이언트(Client)와는 독립적으로 알고리즘 변경 가능
* 쉽게 확장하거나 변경할 수 있는 클래스들의 집합으로 캡슐화
* 필요시 실행중에도 확장/변경이 가능
```


## Ch2. 옵저버 패턴 (Observer Pattern)

```
* 한 객체의 상태가 바뀌면 그 객체에 의존하는 다른 객체들한테 연락이 가고 자동으로 내용이 갱신되는 방식
* 일 대 다 (One-to-Many) 의존성을 정의함
```

* 데이터 취득, 화면에 표시
* 새로운 데이터가 들어올 때마다 디스플레이 갱신
* 시스템 확장이 가능
    * 별도의 디스플레이 항목 생성 가능, 표시 항목 추가/제거 가능


* 주제(subject) 객체
  * 일부 데이터를 관리 

* 옵저버(Observer)
  * 주제 객체를 구독하고 있으며(주제 객체에 등록됨) 주제의 데이터가 바뀌면 갱신 내용을 전달 받음
  * 주제에 의존
  * 구성요소의 형식이 달라도 모두 똑같은 인터페이스로 구현해야만 주체에서 데이터를 받을 수 있음
    * 주체에서 호출 가능한 update() 메소드 필요
  

### <느슨한 결합 (Loose Coupling)>
* 두 객체가 느슨하게 결합 = 상호작용을 하긴 하지만 서로에 대해 잘 모른다는 것
* 변경 사항이 생겨도 무난히 처리 가능하도록 객체 사이의 상호의존성을 최소화


```
* 주제는 옵저버에 대해서 옵저버가 특정 인터페이스(Observer 인터페이스)를 구현한다는 것뿐
* 옵저버는 언제든지 새로 추가 가능
* 옵저버 추가시 주제 변경 할 필요 없음
* 주제와 옵저버는 서로 독립적으로 재사용 가능
* 주제나 옵저버가 바뀌더라도 서로에게 영향을 미치지 않음
```

### 옵저버 패턴
* 푸시방식 : 주제가 모든 데이터를 보내는 방식
* 풀 방식 : 옵저버가 필요한 데이터를 가져가는 방식


---

