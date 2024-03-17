//1 app chat dùng firebase.
//Ở trong collection chats
    // lưu "lastMessage", "members" và "timestamp" mục đích để show ra các chatroom của mình
    //(tương tự như khi mn mở messenger thì thấy được chat với ai, tin nhắn cuối và thời gian gửi).
// Vấn đề xảy ra là vì method không phải Stream, thêm v không lắng nghe lấy data trực tiếp từ collection mà còn xử lý nhiều thứ, nên màn hình đó không update được realtime.
// 1 trong 2 cách: hoặc sửa cấu trúc database, hoặc sửa method đổi sang Stream.

Future<List<Map<String, dynamic>>> getChatRooms(String currentUserId) async {
    try{
        // Lấy data từ collection chart có bản thân là member
        QuerySnapshot querySnapshot =  await _firestore
        .collection("chart").where("members", arrayContain, currentUserId)
        .get();
    }
    
    // Danh sách các phòng chat của bản thân
    List<Map<String, dynamic>> charts = [];

    // Lập qua các phòng
    for (QueryDocumentSnapshot doc in querySnapshot.docs){
        Map<String, dynamic> chatData = doc.data() as Map<String, dynamic>;
        
        // Lấy data mem còn lại
        String otherMemberId = (chatData["members"] as List)
            .firstWhere(memberId => memberId != currentUserId);
        DocumentSnapshot otherMemberDoc =
            await _firestore.collection('users').doc(otherMemberId).get();
        String otherMemberUsername = otherMemberDoc['username'];

        chat.add( {
            'chatId': doc.id,
            'otherMemberId': otherMemberId,
            'otherMemberUsername': otherMemberUsername,
            'lastMessage': chatData['lastMessage'],
            'timestamp': chatData['timestamp'],
        });
    }
    return chat;    
} catch(e){
    print('Error sending message: $e');
    return [];
}