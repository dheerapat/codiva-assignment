<script>
    import head from "../assets/card-head.png";
</script>

<section class="p-8">
    <div class="my-4 max-w-md container mx-auto">
        <div
            class="bg-cover overflow-auto"
            style="background-image: url({head});"
        >
            <div class="py-20 px-4 text-white">
                <h1 class="text-4xl font-bold">สร้างบัญชี</h1>
                <p>สมัครและเริ่มใช้งาน</p>
            </div>
        </div>
        <div class="pt-4 pb-8 px-4 bg-white rounded-b-xl">
            <form>
                <div class="flex mt-4">
                    <div class="m-2">
                        <label for="fname">ชื่อ</label><br />
                        <input
                            class="p-2 mt-2 bg-white border rounded-md w-full text-s"
                            type="text"
                            id="fname"
                            name="fname"
                            placeholder="กรอกชื่อ"
                        />
                    </div>
                    <div class="m-2">
                        <label for="lname">นามสกุล</label><br />
                        <input
                            class="p-2 mt-2 bg-white border rounded-md w-full text-s"
                            type="text"
                            id="lname"
                            name="lname"
                            placeholder="กรอกนามสกุล"
                        />
                    </div>
                </div>
                <div class="flex w-full">
                    <div class="m-2 w-full">
                        <label for="phone">โทรศัพท์</label><br />
                        <input
                            class="p-2 mt-2 bg-white border rounded-md w-full text-s"
                            type="tel"
                            id="phone"
                            name="phone"
                            placeholder="กรอกเบอร์โทรศัพท์"
                        />
                    </div>
                </div>
                <div class="flex w-full">
                    <div class="m-2 w-full">
                        <label for="email">อีเมล</label><br />
                        <input
                            class="p-2 mt-2 bg-white border rounded-md w-full text-s"
                            type="email"
                            id="email"
                            name="email"
                            placeholder="กรอกอีเมล"
                        />
                    </div>
                </div>
                <div class="flex w-full">
                    <div class="m-2 w-full">
                        <label for="password">รหัสผ่าน</label><br />
                        <input
                            class="p-2 mt-2 bg-white border rounded-md w-full text-s"
                            type="password"
                            id="password"
                            name="password"
                            placeholder="กรอกรหัสผ่าน"
                        />
                    </div>
                </div>
                <div class="flex w-full">
                    <div class="m-2 w-full">
                        <p class="mb-4">เพศ</p>
                        <input
                            class="peer/male appearance-none"
                            type="radio"
                            id="male"
                            name="gender"
                        />
                        <label
                            class="py-2 px-4 rounded-full border text-red-500 peer-checked/male:bg-red-500 peer-checked/male:text-white"
                            for="male">ชาย</label
                        >
                        <input
                            class="peer/female appearance-none"
                            type="radio"
                            id="female"
                            name="gender"
                        />
                        <label
                            class="py-2 px-4 rounded-full border text-red-500 peer-checked/female:bg-red-500 peer-checked/female:text-white"
                            for="female">หญิง</label
                        >
                        <input
                            class="peer/na appearance-none"
                            type="radio"
                            id="na"
                            name="gender"
                        />
                        <label
                            class="py-2 px-4 rounded-full border text-red-500 peer-checked/na:bg-red-500 peer-checked/na:text-white"
                            for="na">ไม่ระบุ</label
                        >
                    </div>
                </div>
                <div class="flex w-full">
                    <div class="m-2 w-full">
                        <label for="birthdate">ของขวัญวันเกิดรอคุณอยู่</label
                        ><br />
                        <input
                            class="p-2 mt-2 bg-white border rounded-md w-full text-s"
                            type="date"
                            id="birthdate"
                            name="birthdate"
                        />
                    </div>
                </div>
                <div class="m-4 flex items-start">
                    <span
                        ><input type="checkbox" name="agree" id="agree" /></span
                    >
                    <span class="px-2">
                        ฉันได้อ่านและยอมรับ ข้อกำหนดการใช้งาน และ
                        นโยบายความเป็นส่วนตัว ของสเวนเซ่นส์
                    </span>
                </div>
                <div class="m-4 flex items-start">
                    <span
                        ><input type="checkbox" name="email-sub" id="email-sub" /></span
                    >
                    <span class="px-2">
                        ฉันยินยอมรับข้อมูลข่าวสาร กิจกรรมส่งเสริมการขายต่างๆ
                        จากสเวนเซ่นส์และบริษัทในเครือ
                        โดยเราจะเก็บข้อมูลของท่านไว้เป็นความลับ
                        สามารถศึกษาเงื่อนไขหรือข้อตกลง นโยบายความเป็นส่วนตัว
                        เพิ่มเติมได้ที่เว็บไซต์ของบริษัทฯ
                    </span>
                </div>
                <div class="flex justify-center">
                    <button
                        class="border rounded-full px-16 py-3 mt-4 bg-red-500 text-white"
                        >สมัครสมาชิก</button
                    >
                </div>
            </form>
        </div>
    </div>
</section>
