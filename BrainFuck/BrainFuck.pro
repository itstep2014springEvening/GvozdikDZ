TEMPLATE = app
CONFIG += console
CONFIG -= app_bundle
CONFIG -= qt
CONFIG += c++11

SOURCES += main.cpp \
    machine.cpp \
    term.cpp \
    next.cpp \
    previous.cpp \
    inc.cpp \
    dec.cpp \
    put.cpp \
    get.cpp \
    open.cpp \
    close.cpp

include(deployment.pri)
qtcAddDeployment()

HEADERS += \
    machine.h \
    term.h \
    next.h \
    previous.h \
    inc.h \
    dec.h \
    put.h \
    get.h \
    open.h \
    close.h

