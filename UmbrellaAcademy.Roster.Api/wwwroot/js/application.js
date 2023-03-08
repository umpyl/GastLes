function loadMembers() {
    fetch('api/member')
        .then(response => response.json())
        .then(data => displayMembers(data))
        .catch(error => console.error('Unable to get items.', error));
}

function searchByNumber() {
    const number = document.getElementById("number").value;
    if (number == '') {
        loadMembers();
        return;
    }

    fetch('api/member/' + number)
        .then(response => response.json())
        .then(data => displayMembers([ data ]))
        .catch(error => console.error('Unable to get items.', error));
}

function fetchImageByMemberNumber(number, func) {
    fetch('api/image/member/' + number)
        .then(response => response.json())        
        .then(data => func(data))
        .catch(error => console.error('Unable to get items.', error));
}

function displayMembers(members) {
    const tBody = document.getElementById('members');
    tBody.innerHTML = '';
    members.forEach(member => {
        const tr = tBody.insertRow();
        const newline = document.createElement("br");

        const td1 = tr.insertCell(0);
        const memberImg = document.createElement('img');
        memberImg.id = 'memberimage' + member.number;

        fetchImageByMemberNumber(member.number, (image) => {
            const memberNumber = member.number;
            const memberImage = document.getElementById('memberimage' + memberNumber);
            memberImage.src = image;
        });        

        td1.appendChild(memberImg);

        const td2 = tr.insertCell(1);        
        td2.append(member.name);

        const td3 = tr.insertCell(2);
        var nicknames = member.nicknames;
        for (var i = 0; i < nicknames.length; i++) {
            td3.append(nicknames[i]);
            if (i < nicknames.length - 1) {
                td3.append(newline);
            }
        }

        const td4 = tr.insertCell(3);
        td4.append(member.number);

        const td5 = tr.insertCell(4);
        var skills = member.skills;
        for (var i = 0; i < skills.length; i++) {
            td5.append(skills[i]);
            if (i < skills.length - 1) {
                const newline = document.createElement("br");
                td5.append(newline);
            }
        }
    });
}