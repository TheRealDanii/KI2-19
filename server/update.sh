if [ -f /home/ki219/KI2-19/server/projects.json ]
then
echo 'Directory exists deleting...'
rm -rf /home/ki219/KI2-19
echo 'Directory deleted'
fi

echo 'Cloning respository...'
cd /home/ki219
git clone https://github.com/Dzefo/KI2-19

echo 'Respository cloned'

service ki219 stop

rm /home/ki219/projects.json

mv /home/ki219/KI2-19/server/projects.json /home/ki219/projects.json

echo 'Cleaning up...'
rm -rf /home/ki219/KI2-19

service ki219 start
echo 'Projects updated'

