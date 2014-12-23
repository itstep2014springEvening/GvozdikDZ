TEMPLATE = app
CONFIG += console
CONFIG -= app_bundle
CONFIG -= qt
CONFIG += c++11

SOURCES += main.cpp \
    stack.cpp \
    implementation.cpp \
    consolestack.cpp \
    prettystack.cpp


HEADERS += \
    stack.h \
    implementation.h \
    consolestack.h \
    prettystack.h

