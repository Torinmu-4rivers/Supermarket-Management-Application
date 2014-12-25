--
-- PostgreSQL database dump
--

-- Dumped from database version 9.3.5
-- Dumped by pg_dump version 9.3.5
-- Started on 2014-12-25 22:07:20

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 176 (class 3079 OID 11750)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 1976 (class 0 OID 0)
-- Dependencies: 176
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 170 (class 1259 OID 18497)
-- Name: customers; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE customers (
    cust_id character varying(10) NOT NULL,
    cust_name character varying(30),
    cust_gender character varying(1),
    cust_age character varying(2),
    cust_address character varying(30),
    cust_phone_num character varying(15)
);


ALTER TABLE public.customers OWNER TO postgres;

--
-- TOC entry 173 (class 1259 OID 18512)
-- Name: employees; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE employees (
    employ_id character varying(10) NOT NULL,
    user_id character varying(10),
    employ_name character varying(30),
    employ_gender character varying(1),
    employ_age character varying(2),
    employ_phone_number character varying(15),
    employ_address character varying(50),
    employ_start_date date
);


ALTER TABLE public.employees OWNER TO postgres;

--
-- TOC entry 171 (class 1259 OID 18502)
-- Name: products; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE products (
    prod_id character varying(10) NOT NULL,
    prod_name character varying(30),
    prod_color character varying(10),
    prod_size character varying(5),
    prod_price numeric(15,3),
    prod_desc character varying(50)
);


ALTER TABLE public.products OWNER TO postgres;

--
-- TOC entry 174 (class 1259 OID 18522)
-- Name: sell; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE sell (
    cust_id character varying(10) NOT NULL,
    prod_id character varying(10) NOT NULL,
    sell_date date,
    quantity smallint NOT NULL,
    employ_id character varying(10)
);


ALTER TABLE public.sell OWNER TO postgres;

--
-- TOC entry 175 (class 1259 OID 18532)
-- Name: stores; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE stores (
    lo_id character varying(10) NOT NULL,
    prod_id character varying(10),
    prod_exp_date date,
    prod_quantity smallint,
    prod_date date
);


ALTER TABLE public.stores OWNER TO postgres;

--
-- TOC entry 172 (class 1259 OID 18507)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE users (
    user_id character varying(10) NOT NULL,
    user_name character varying(15),
    user_pw character varying(10),
    isadmin character varying(5)
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 1963 (class 0 OID 18497)
-- Dependencies: 170
-- Data for Name: customers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY customers (cust_id, cust_name, cust_gender, cust_age, cust_address, cust_phone_num) FROM stdin;
01	aaaa	M	20	aabbcc	0123456
02	bbbb	M	20	aabbdd	0123698
03	cccc	F	20	aabbee	0123845
04	ccdd	F	60	aaccee	0123745
05	kkii	F	09	aacckk	0123488
\.


--
-- TOC entry 1966 (class 0 OID 18512)
-- Dependencies: 173
-- Data for Name: employees; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY employees (employ_id, user_id, employ_name, employ_gender, employ_age, employ_phone_number, employ_address, employ_start_date) FROM stdin;
01	001	afasfjg	M	23	0123588	asfdsdf	2014-01-01
02	002	biuvfjg	M	24	0123774	oivhfjf	2014-01-01
03	003	biasf	F	20	0123552	oioccdd	2014-01-01
04	004	blvasf	F	20	0123552	oiooold	2014-01-02
05	005	olopasf	F	24	0123572	oiold	2014-01-03
\.


--
-- TOC entry 1964 (class 0 OID 18502)
-- Dependencies: 171
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY products (prod_id, prod_name, prod_color, prod_size, prod_price, prod_desc) FROM stdin;
001	sua	trang	nho	5.000	
002	sua	trang	lon	5.000	
003	mi	do	nho	6.000	
004	xa phong	do	nho	7.000	
005	bot giat	den	lon	7.000	
\.


--
-- TOC entry 1967 (class 0 OID 18522)
-- Dependencies: 174
-- Data for Name: sell; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY sell (cust_id, prod_id, sell_date, quantity, employ_id) FROM stdin;
01	001	2014-12-04	2	01
02	001	2014-11-04	3	01
03	003	2014-11-08	3	03
04	005	2013-01-08	1	04
05	002	2012-01-09	6	02
\.


--
-- TOC entry 1968 (class 0 OID 18532)
-- Dependencies: 175
-- Data for Name: stores; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY stores (lo_id, prod_id, prod_exp_date, prod_quantity, prod_date) FROM stdin;
001	001	2015-01-01	10	2013-01-06
002	002	2014-01-02	20	2013-01-06
003	003	2014-01-04	20	2013-01-05
004	004	2014-01-06	30	2013-01-02
005	005	2014-01-03	0	2013-01-04
\.


--
-- TOC entry 1965 (class 0 OID 18507)
-- Dependencies: 172
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY users (user_id, user_name, user_pw, isadmin) FROM stdin;
001	100123	dfkjdf	1
002	100554	dfkjdf	0
003	100784	dsfjdf	0
004	100844	asdffv	0
005	100009	asdf44	0
\.


--
-- TOC entry 1842 (class 2606 OID 18501)
-- Name: cust_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY customers
    ADD CONSTRAINT cust_pkey PRIMARY KEY (cust_id);


--
-- TOC entry 1848 (class 2606 OID 18516)
-- Name: employ_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY employees
    ADD CONSTRAINT employ_pkey PRIMARY KEY (employ_id);


--
-- TOC entry 1852 (class 2606 OID 18536)
-- Name: lo_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY stores
    ADD CONSTRAINT lo_pkey PRIMARY KEY (lo_id);


--
-- TOC entry 1844 (class 2606 OID 18506)
-- Name: prod_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY products
    ADD CONSTRAINT prod_pkey PRIMARY KEY (prod_id);


--
-- TOC entry 1850 (class 2606 OID 18526)
-- Name: sell_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY sell
    ADD CONSTRAINT sell_pkey PRIMARY KEY (cust_id, prod_id);


--
-- TOC entry 1846 (class 2606 OID 18511)
-- Name: user_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY users
    ADD CONSTRAINT user_pkey PRIMARY KEY (user_id);


--
-- TOC entry 1853 (class 2606 OID 18517)
-- Name: employ_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY employees
    ADD CONSTRAINT employ_fkey FOREIGN KEY (user_id) REFERENCES users(user_id);


--
-- TOC entry 1854 (class 2606 OID 18527)
-- Name: sell_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY sell
    ADD CONSTRAINT sell_fkey FOREIGN KEY (prod_id) REFERENCES products(prod_id);


--
-- TOC entry 1855 (class 2606 OID 18537)
-- Name: store_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY stores
    ADD CONSTRAINT store_fkey FOREIGN KEY (prod_id) REFERENCES products(prod_id);


--
-- TOC entry 1975 (class 0 OID 0)
-- Dependencies: 5
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2014-12-25 22:07:20

--
-- PostgreSQL database dump complete
--

