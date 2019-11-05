if [ -f /etc/systemd/system/ki219.service ]

then

service ki219 stop

rm /etc/systemd/system/ki219.service

systemctl daemon-reload

fi


rm /home/ki219/start.sh


{

echo '#!/bin/bash'

echo 'cd /home/ki219'

echo 'npm start'

}>/home/ki219/start.sh


chmod +x /home/ki219/start.sh


{

echo '[Unit]'

echo 'Description=ki219'

echo 'StartLimitIntervalSec=0'

echo '[Service]'

echo 'Type=simple'

echo 'Restart=always'

echo 'RestartSec=1'

echo 'User=root'

echo 'ExecStart=/home/ki219/start.sh'

echo '[Install]'

echo 'WantedBy=multi-user.target '

}>/etc/systemd/system/ki219.service


systemctl enable ki219

service ki219 start
