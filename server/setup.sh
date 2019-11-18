if [ -f /etc/systemd/system/ki219.service ]
then
service ki219 stop
rm /etc/systemd/system/ki219.service
systemctl daemon-reload
fi

rm $PWD/.env
{
echo 'DOMAIN=ki219.devstall.de'
}>$PWD/.env

rm $PWD/start.sh
{
echo '#!/bin/bash'
echo "cd ${PWD}"
echo 'npm start'
}>$PWD/start.sh
chmod +x $PWD/start.sh

{
echo '[Unit]'
echo 'Description=ki219'
echo 'StartLimitIntervalSec=0'
echo '[Service]'
echo 'Type=simple'
echo 'Restart=always'
echo 'RestartSec=1'
echo 'User=root'
echo "ExecStart=${PWD}/start.sh"
echo '[Install]'
echo 'WantedBy=multi-user.target '
}>/etc/systemd/system/ki219.service
systemctl enable ki219
service ki219 start
