interface AndroidPhone {
    void charge();
}
interface IPhone {
    void charge();
}
class AndroidCharger {
    public void charge(AndroidPhone androidPhone) {
        androidPhone.charge();
    }
}

class IPhoneCharger {
    public void charge(IPhone iPhone){
        iPhone.charge();
    }
}

class OnePlus5 implements AndroidPhone {
    public void charge() {
        System.out.println("Charging OP5");
    }
}

class IPhoneX implements IPhone {
    public void charge() {
        System.out.println("Charging IPhone X");
    }
}

class AndroidToIPhoneAdapter implements IPhone {

    AndroidPhone androidPhone;

    public AndroidToIPhoneAdapter(AndroidPhone androidPhone) {
        this.androidPhone = androidPhone;
    }

    public void charge() {
        androidPhone.charge();
    }
}

public class Main {

    public static void main(String[] args) {

        AndroidCharger androidCharger = new AndroidCharger();
        AndroidPhone androidPhone = new OnePlus5();
        androidCharger.charge(androidPhone);

        IPhoneCharger iPhoneCharger = new IPhoneCharger();
        IPhone iPhone = new IPhoneX();
        iPhoneCharger.charge(iPhone);

        AndroidToIPhoneAdapter adapter = new AndroidToIPhoneAdapter(androidPhone);
        iPhoneCharger.charge(adapter);


    }
}