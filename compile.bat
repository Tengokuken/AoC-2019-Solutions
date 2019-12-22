csc %1
SET exe=%~n1.exe
echo %exe%
%exe% %2
DEL %exe%