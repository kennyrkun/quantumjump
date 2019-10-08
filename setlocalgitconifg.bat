@echo off
set /P username="github username:"
set /p email="github email:"

git config --local user.name %username%
git config --local user.email %email%

echo Set local git config.